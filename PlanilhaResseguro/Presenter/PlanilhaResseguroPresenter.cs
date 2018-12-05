using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;


namespace PlanilhaResseguro.Presenter
{
    class PlanilhaResseguroPresenter
    {
        public static bool PlanilhaSinistro(string filePath,string pathSaida, string idJira)
        {
            Console.WriteLine($@"Lendo o arquivo {filePath}");
            Console.WriteLine();

            FileInfo existingFile = new FileInfo(filePath);
            ExcelPackage package = new ExcelPackage(existingFile);

            // Seleciona a primeira planilha do Doc Excel
            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

            var apolice = worksheet.Cells["A2:A"];
            var endosso = worksheet.Cells["B2:B"];
            var sinistros = worksheet.Cells["C2:C"];

            DateTime data = DateTime.Today;
            var dataMovimento = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            //Pega o CD_GRUPO_RAMO
            var cdRamos = worksheet.Cells["E2:E"];
            List<string> cdRamoList = new List<string>();
            foreach (var cdRamo in cdRamos)
            {
                if (cdRamo.Value != null)
                {
                    string ramo = cdRamo.Value.ToString();
                    if (ramo.Length > 2)
                    {
                        ramo = ramo.Substring(2);
                        cdRamoList.Add(ramo);
                    }
                    else
                    {
                        cdRamoList.Add(ramo);
                    }
                }

            }
            var cdGrupoRamo = BuscaCdGrupo(cdRamoList);
            //Busca o CD_LANCAMENTO
            var dsLancamento = worksheet.Cells["F2:F"];
            List<ExcelRangeBase> dsLancamentoList = dsLancamento.ToList();
            var cdLancamento = BuscaCdLancamento(dsLancamentoList);

            var valorMovimento = worksheet.Cells["G2:G"];

            var resegurador = worksheet.Cells["H2:H"];

            var contrato = worksheet.Cells["I2:I"];

            Console.WriteLine(@"Finalizando o processamento");
            Console.WriteLine();

            // Criando planilha no padrão
            var package2 = new ExcelPackage();

            // Add a new worksheet to the empty workbook
            ExcelWorksheet worksheet2 = package2.Workbook.Worksheets.Add("Resseguro");
            //Add the headers
            worksheet2.Cells[1, 1].Value = "ID_PLANILHA";
            worksheet2.Cells[1, 2].Value = "CD_APOLICE";
            worksheet2.Cells[1, 3].Value = "CD_ITEM";
            worksheet2.Cells[1, 4].Value = "CD_ENDOSSO";
            worksheet2.Cells[1, 5].Value = "CD_RAMO";
            worksheet2.Cells[1, 6].Value = "CD_GRUPO_RAMO";
            worksheet2.Cells[1, 7].Value = "DT_MOV";
            worksheet2.Cells[1, 8].Value = "CD_LANCAMENTO";
            worksheet2.Cells[1, 9].Value = "DS_LANCAMENTO";
            worksheet2.Cells[1, 10].Value = "CD_AVS_SGO";
            worksheet2.Cells[1, 11].Value = "CD_RESSEGURADORA";
            worksheet2.Cells[1, 12].Value = "CD_ENDOSSO_MS10";
            worksheet2.Cells[1, 13].Value = "VL_MOVIMENTO";
            worksheet2.Cells[1, 14].Value = "CD_CONTABIL";
            worksheet2.Cells[1, 15].Value = "CD_CTR_RESSEGURO";

            int startRow = 2;
            int row = startRow;
            foreach (var apol in apolice)
            {
                worksheet2.Cells[row, 1].Value = idJira;
                worksheet2.Cells[row, 2].Value = apol.Value.ToString();
                worksheet2.Cells[row, 3].Value = "0";
                worksheet2.Cells[row, 4].Value = "0";
                worksheet2.Cells[row, 5].Value = cdRamoList[row - 2];
                worksheet2.Cells[row, 6].Value = cdGrupoRamo[row - 2];
                worksheet2.Cells[row, 7].Value = dataMovimento.ToString();
                worksheet2.Cells[row, 8].Value = cdLancamento[row - 2];
                worksheet2.Cells[row, 9].Value = dsLancamento[row, 6].Value.ToString();
                worksheet2.Cells[row, 10].Value = sinistros[row, 3].Value.ToString();
                worksheet2.Cells[row, 11].Value = resegurador[row, 8].Value.ToString();
                if (endosso[row, 2].Value == null || endosso[row, 2].Value.ToString() == "0")
                {
                    worksheet2.Cells[row, 12].Value = "0";
                }
                else
                {
                    worksheet2.Cells[row, 12].Value = endosso[row, 2].Value.ToString();
                }
                worksheet2.Cells[row, 13].Value = String.Format("{0:0.00}", valorMovimento[row, 7].Value);
                worksheet2.Cells[row, 14].Value = "AV1";
                worksheet2.Cells[row, 15].Value = contrato[row, 9].Value.ToString();
                row++;
            }
            
            try
            {
                Stream stream = File.Create(pathSaida);
                package2.SaveAs(stream);
                stream.Close();

                File.ReadAllBytes(pathSaida);
                return true;
            }
           catch
            {
                return false;
            }
        }
        public static bool PlanilhaResseguroPremio(string filePath,string pathSaida, string idJira)
        {
            Console.WriteLine($@"Lendo o arquivo {filePath}");
            Console.WriteLine();

            FileInfo existingFile = new FileInfo(filePath);
            ExcelPackage package = new ExcelPackage(existingFile);

            // Seleciona a primeira planilha do Doc Excel
            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

            var apolice = worksheet.Cells["A2:A"];
            var endosso = worksheet.Cells["B2:B"];

            //Pega o CD_GRUPO_RAMO
            var cdRamos = worksheet.Cells["C2:C"];
            List<string> cdRamoList = new List<string>();
            foreach (var cdRamo in cdRamos)
            {
                string ramo = cdRamo.Value.ToString();
                if (ramo.Length > 2)
                {
                    ramo = ramo.Substring(2);
                    cdRamoList.Add(ramo);
                }
                else
                {
                    cdRamoList.Add(ramo);
                }
            }
            var cdGrupoRamo = BuscaCdGrupo(cdRamoList);
            //Busca o CD_LANCAMENTO
            var dsLancamento = worksheet.Cells["E2:E"];

            List<string> cdLancamentoL = new List<string>();
            foreach (var lanc in dsLancamento)
            {
                int cdLancamento;
                if (lanc.Value.Equals("PRÊMIO") || lanc.Value.Equals("PREMIO"))
                {
                    cdLancamento = 100;
                    cdLancamentoL.Add(cdLancamento.ToString());
                }
                else
                {
                    cdLancamento = 200;
                    cdLancamentoL.Add(cdLancamento.ToString());
                }

            }

            var valorMovimentos = worksheet.Cells["F2:F"];

            var codRessegurador = worksheet.Cells["G2:G"];

            var contrato = worksheet.Cells["I2:I"];

            //Vamos considerar que a data seja o dia de hoje, mas pode ser qualquer data.
            DateTime data = DateTime.Today;
            var dataMovimento = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            Console.WriteLine();

            // Criando planilha no padrão
            var package2 = new ExcelPackage();

            // Add a new worksheet to the empty workbook
            ExcelWorksheet worksheet2 = package2.Workbook.Worksheets.Add("Resseguro");
            //Add the headers
            worksheet2.Cells[1, 1].Value = "ID_PLANILHA";
            worksheet2.Cells[1, 2].Value = "CD_APOLICE";
            worksheet2.Cells[1, 3].Value = "CD_ITEM";
            worksheet2.Cells[1, 4].Value = "CD_ENDOSSO";
            worksheet2.Cells[1, 5].Value = "CD_RAMO";
            worksheet2.Cells[1, 6].Value = "CD_GRUPO_RAMO";
            worksheet2.Cells[1, 7].Value = "DT_MOV";
            worksheet2.Cells[1, 8].Value = "CD_LANCAMENTO";
            worksheet2.Cells[1, 9].Value = "DS_LANCAMENTO";
            worksheet2.Cells[1, 10].Value = "CD_AVS_SGO";
            worksheet2.Cells[1, 11].Value = "CD_RESSEGURADORA";
            worksheet2.Cells[1, 12].Value = "CD_ENDOSSO_MS10";
            worksheet2.Cells[1, 13].Value = "VL_MOVIMENTO";
            worksheet2.Cells[1, 14].Value = "CD_CONTABIL";
            worksheet2.Cells[1, 15].Value = "CD_CTR_RESSEGURO";

            int startRow = 2;
            int row = startRow;
            foreach (var apol in apolice)
            {
                worksheet2.Cells[row, 1].Value = idJira;
                worksheet2.Cells[row, 2].Value = apol.Value.ToString();
                worksheet2.Cells[row, 3].Value = "0";
                worksheet2.Cells[row, 4].Value = "0";
                worksheet2.Cells[row, 5].Value = cdRamoList[row - 2];
                worksheet2.Cells[row, 6].Value = cdGrupoRamo[row - 2];
                worksheet2.Cells[row, 7].Value = dataMovimento.ToString();
                worksheet2.Cells[row, 8].Value = cdLancamentoL[row - 2];
                worksheet2.Cells[row, 9].Value = dsLancamento[row, 5].Value.ToString();
                worksheet2.Cells[row, 10].Value = null;
                worksheet2.Cells[row, 11].Value = codRessegurador[row, 7].Value.ToString();
                if (endosso[row, 2].Value.ToString() == "0")
                {
                    worksheet2.Cells[row, 12].Value = "0";
                }
                else
                {
                    worksheet2.Cells[row, 12].Value = endosso[row, 2].Value.ToString();
                }

                worksheet2.Cells[row, 13].Value = String.Format("{0:0.00}", valorMovimentos[row, 6].Value);
                worksheet2.Cells[row, 14].Value = "PR1";
                worksheet2.Cells[row, 15].Value = contrato[row, 9].Value.ToString();
                row++;
            }
            try
            {
                Console.WriteLine(@"Finalizando geração da planilha");
               
                Stream stream = File.Create(pathSaida);
                package2.SaveAs(stream);
                stream.Close();

                File.ReadAllBytes(pathSaida);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> BuscaCdGrupo(List<string> cdRamosList)
        {
            List<string> cdGrupoRamoList = new List<string>();

            using (var db = new DB_BIPRODUCAO_ODSEntities1())
            {
                foreach (var cdRamo in cdRamosList)
                {
                    var query = db.TB_ODS_RAMO.FirstOrDefault(x => x.CD_RAMO_ANT == cdRamo);
                    if (query != null)
                    {
                        string cdGrupoRamo = query.CD_RAMO.Substring(1, 1);
                        cdGrupoRamoList.Add(cdGrupoRamo);
                    }
                }
            }
            return cdGrupoRamoList;
        }

        public static List<int> BuscaCdLancamento(List<ExcelRangeBase> dsLancamentos)
        {
            List<int> cdLancamentos = new List<int>();
            using (var db = new DB_BIPRODUCAO_ODSEntities1())
            {
                foreach (var dsLancamento in dsLancamentos)
                {
                    if (dsLancamento.Value != null)
                    {
                        if (dsLancamento.Value.ToString() == "Aviso de Salvado")
                        {
                            dsLancamento.Value = "Apropriação de Salvados";
                        }
                        var query = db.TB_ODS_EVENTO.FirstOrDefault(x => x.DS_EVENTO == dsLancamento.Value.ToString() && x.ID_SISTEMA == 9);
                        if (query != null)
                        {

                            int cdLancamento = query.CD_EVENTO;
                            switch (cdLancamento)
                            {
                                case 426:
                                    cdLancamento = 26;
                                    break;
                                case 422:
                                    cdLancamento = 22;
                                    break;
                            }
                            cdLancamentos.Add(cdLancamento);
                        }
                        else
                        {
                            cdLancamentos.Add(0);
                            Console.WriteLine($"Não encontrado para o evento " + dsLancamento.Value);
                        }
                    }
                }
            }
            return cdLancamentos;
        }
    }
}
