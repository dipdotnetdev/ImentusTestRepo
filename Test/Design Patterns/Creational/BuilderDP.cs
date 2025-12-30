using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Creational
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
    }

    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public abstract void SetReportContent();
    }

    public class ExcelReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel Report";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content";
        }
    }

    public class PDFReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF Report";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content";
        }
    }
    
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportFooter();
            reportBuilder.SetReportContent();

            return reportBuilder.GetReport();
        }
    }
    public class BuilderDP
    {
        static void Main5()
        {
            ReportDirector reportDirector = new ReportDirector();

            PDFReport pdfReport = new PDFReport();
            Report report = reportDirector.MakeReport(pdfReport);
            

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
        }
    }
}
