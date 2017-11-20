using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Windows.Forms;



namespace CapaPresentación
{
    public class CapaLogica
    {
        public void mostrar(OdbcConnection cn,string documento)
        {

            try
            {
                ReportDocument report = new ReportDocument();
                report.Load(documento);
                report.SetDatabaseLogon("root", "");
                VisorBG1 visor = new VisorBG1();
                visor.crystalReportViewer1.ReportSource = report;

                visor.ShowDialog();
            }
            catch (CrystalReportsException e) {

                MessageBox.Show("Error" + e);
                
            }
        }

        public void mostrarestador(string documento)
        {

            ReportDocument report = new ReportDocument();
            report.Load(documento);
            
            VisorEstadoResultado visor = new VisorEstadoResultado();
            visor.EstadoResultados.ReportSource = report;
            visor.ShowDialog();

        }

        public void mostrarbg2(string documento) {

            ReportDocument report = new ReportDocument();
            report.Load(documento);
            VisorBG2  visor = new VisorBG2();
            visor.BG2.ReportSource = report;
            visor.ShowDialog();

        }

        public void mostrarbg3(string documento)
        {

            ReportDocument report = new ReportDocument();
            report.Load(documento);
            VisorBG3 visor = new VisorBG3();
            visor.BG3.ReportSource = report;
            visor.ShowDialog();

        }

        public void mostrarbg4(string documento)
        {

            ReportDocument report = new ReportDocument();
            report.Load(documento);
            VisorBG4 visor = new VisorBG4();
            visor.BG4.ReportSource = report;
            visor.ShowDialog();
        }

        public void mostrarbg5(string documento)
        {
            ReportDocument report = new ReportDocument();
            report.Load(documento);
            VisorBG5 visor = new VisorBG5();
            visor.BG5.ReportSource = report;
            visor.ShowDialog();
        }



    }
}
