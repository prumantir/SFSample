using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data;
using System.Collections;
using Syncfusion.Pdf.Tables;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Lists;
using Syncfusion.Pdf.Parsing;
using System.Data.SqlServerCe;
namespace SFSample
{
    public partial class PdfController : Controller
    {      
        public ActionResult PdfFeatures()
        {
            return View();
        }
        # region Fields
        PdfDocument doc;
        private PdfPage m_page;
        System.Drawing.Color gray = System.Drawing.Color.FromArgb(255, 77, 77, 77);
        System.Drawing.Color black = System.Drawing.Color.FromArgb(255, 0, 0, 0);
        System.Drawing.Color white = System.Drawing.Color.FromArgb(255, 255, 255, 255);
        System.Drawing.Color violet = System.Drawing.Color.FromArgb(255, 151, 108, 174);
        #endregion
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfFeatures(string Browser)
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            m_page = document.Pages.Add();
            PdfGraphics g = m_page.Graphics;
            PdfFont headerFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 35);
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);
            g.DrawRectangle(new PdfSolidBrush(gray), new RectangleF(0, 0, m_page.Graphics.ClientSize.Width, m_page.Graphics.ClientSize.Height));
            g.DrawRectangle(new PdfSolidBrush(black), new RectangleF(0, 0, m_page.Graphics.ClientSize.Width, 130));
            g.DrawRectangle(new PdfSolidBrush(white), new RectangleF(0, 400, m_page.Graphics.ClientSize.Width, m_page.Graphics.ClientSize.Height - 450));
            g.DrawString("Enterprise", headerFont, new PdfSolidBrush(violet), new PointF(10, 20));
            g.DrawRectangle(new PdfSolidBrush(violet), new RectangleF(10, 63, 140, 35));
            g.DrawString("Reporting Solutions", subHeadingFont, new PdfSolidBrush(black), new PointF(15, 70));
            PdfLayoutResult result = HeaderPoints("Develop cloud-ready reporting applications in as little as 20% of the time.", 15);
            result = HeaderPoints("Proven, reliable platform thousands of users over the past 10 years.", result.Bounds.Bottom + 15);
            result = HeaderPoints("Microsoft Excel, Word, Adobe PDF, RDL display and editing.", result.Bounds.Bottom + 15);
            result = HeaderPoints("Why start from scratch? Rely on our dependable solution frameworks", result.Bounds.Bottom + 15);
            result = BodyContent("Deployment-ready framework tailored to your needs.", result.Bounds.Bottom + 45);
            result = BodyContent("Our architects and developers have years of reporting experience.", result.Bounds.Bottom + 25);
            result = BodyContent("Solutions available for web, desktop, and mobile applications.", result.Bounds.Bottom + 25);
            result = BodyContent("Backed by our end-to-end product maintenance infrastructure.", result.Bounds.Bottom + 25);
            result = BodyContent("The quickest path from concept to delivery.", result.Bounds.Bottom + 25);
            PdfPen redPen = new PdfPen(PdfBrushes.Red, 2);
            g.DrawLine(redPen, new PointF(40, result.Bounds.Bottom + 92), new PointF(40, result.Bounds.Bottom + 145));
            float headerBulletsXposition = 40;
            PdfTextElement txtElement = new PdfTextElement("The Experts");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 90, 450, 200));
            PdfPen violetPen = new PdfPen(PdfBrushes.Violet, 2);
            g.DrawLine(violetPen, new PointF(headerBulletsXposition + 310, result.Bounds.Bottom + 92), new PointF(headerBulletsXposition + 310, result.Bounds.Bottom + 145));
            txtElement = new PdfTextElement("Accurate Estimates");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 320, result.Bounds.Bottom + 90, 450, 200));
            txtElement = new PdfTextElement("A substantial number of .NET reporting applications use our frameworks");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 5, 250, 200));
            txtElement = new PdfTextElement("Given our expertise, you can expect estimates to be accurate.");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 320, result.Bounds.Y, 250, 200));
            PdfPen greenPen = new PdfPen(PdfBrushes.Green, 2);
            g.DrawLine(greenPen, new PointF(40, result.Bounds.Bottom + 32), new PointF(40, result.Bounds.Bottom + 85));
            txtElement = new PdfTextElement("Product Licensing");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 30, 450, 200));
            PdfPen bluePen = new PdfPen(PdfBrushes.Blue, 2);
            g.DrawLine(bluePen, new PointF(headerBulletsXposition + 310, result.Bounds.Bottom + 32), new PointF(headerBulletsXposition + 310, result.Bounds.Bottom + 85));
            txtElement = new PdfTextElement("About Syncfusion");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 320, result.Bounds.Bottom + 30, 450, 200));
            txtElement = new PdfTextElement("Solution packages can be combined with product licensing for great cost savings.");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 5, 250, 200));
            txtElement = new PdfTextElement("Syncfusion has more than 7,000 customers including large financial institutions and Fortune 100 companies.");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
            result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 320, result.Bounds.Y, 250, 200));
            string imgPath = ResolveApplicationImagePath("Reporting-Edition.jpg");
            g.DrawImage(PdfImage.FromFile(imgPath), 280, 600, 300, 170);
            g.DrawString("All trademarks mentioned belong to their owners.", new PdfStandardFont(PdfFontFamily.TimesRoman, 8, PdfFontStyle.Italic), PdfBrushes.White, new PointF(10, g.ClientSize.Height - 30));
           Syncfusion.Pdf.Interactive.PdfTextWebLink linkAnnot = new Syncfusion.Pdf.Interactive.PdfTextWebLink();
            linkAnnot.Url = "http://www.syncfusion.com";
            linkAnnot.Text = "www.syncfusion.com";
            linkAnnot.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 8, PdfFontStyle.Italic);
            linkAnnot.Brush = PdfBrushes.White;
            linkAnnot.DrawTextWebLink(m_page, new PointF(g.ClientSize.Width - 100, g.ClientSize.Height - 30));
            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }
        private PdfLayoutResult BodyContent(string text, float yPosition)
        {
            float headerBulletsXposition = 35;
            PdfTextElement txtElement = new PdfTextElement("3");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.ZapfDingbats, 16);
            txtElement.Brush = new PdfSolidBrush(violet);
            txtElement.StringFormat = new PdfStringFormat();
            txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
            txtElement.StringFormat.LineLimit = true;
            txtElement.Draw(m_page, new RectangleF(headerBulletsXposition, yPosition, 320, 100));
            txtElement = new PdfTextElement(text);
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 17);
            txtElement.Brush = new PdfSolidBrush(white);
            txtElement.StringFormat = new PdfStringFormat();
            txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
            txtElement.StringFormat.LineLimit = true;
            PdfLayoutResult result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 25, yPosition, 450, 130));
            return result;
        }
        private PdfLayoutResult HeaderPoints(string text, float yPosition)
        {
            float headerBulletsXposition = 220;
            PdfTextElement txtElement = new PdfTextElement("l");
            txtElement.Font = new PdfStandardFont(PdfFontFamily.ZapfDingbats, 10);
            txtElement.Brush = new PdfSolidBrush(violet);
            txtElement.StringFormat = new PdfStringFormat();
            txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
            txtElement.StringFormat.LineLimit = true;
            txtElement.Draw(m_page, new RectangleF(headerBulletsXposition, yPosition, 300, 100));
            txtElement = new PdfTextElement(text);
            txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11);
            txtElement.Brush = new PdfSolidBrush(white);
            txtElement.StringFormat = new PdfStringFormat();
            txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
            txtElement.StringFormat.LineLimit = true;
            PdfLayoutResult result = txtElement.Draw(m_page, new RectangleF(headerBulletsXposition + 20, yPosition, 320, 100));
            return result;
        }
        protected string ResolveApplicationImagePath(string fileName)
        {
            string dataPath = new System.IO.DirectoryInfo(Request.PhysicalApplicationPath + "\\Content\\Images\\Pdf").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
     }
    public static class PdfExtension
    {
        public static PdfResult ExportAsActionResult(this PdfDocument PdfDoc, string filename, HttpResponse response, HttpReadType type)
        {
            return new PdfResult(PdfDoc, filename, response, type);
        }
        public static PdfResult ExportAsActionResult(this PdfLoadedDocument pdfdoc, string filename, HttpResponse response, HttpReadType type)
        {
            return new PdfResult(pdfdoc, filename, response, type);
        }
     }
    public class PdfResult : ActionResult
    {
        private string m_filename;
        private PdfDocument m_pdfDocument;
        private PdfLoadedDocument m_pdfLoadedDocument;
        private HttpResponse m_response;
        private HttpReadType m_readType;
        public string FileName
        {
            get
            {
                return m_filename;
            }
            set
            {
                m_filename = value;
            }
        }
        public PdfDocument PdfDoc
        {
            get
            {
                if (m_pdfDocument != null)
                    return m_pdfDocument;
                return null;
            }
        }
        public PdfLoadedDocument pdfLoadedDoc
        {
            get
            {
                if (m_pdfLoadedDocument != null)
                    return m_pdfLoadedDocument;
                return null;
            }
        }
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        public HttpReadType ReadType
        {
            get
            {
                return m_readType;
            }
            set
            {
                m_readType = value;
            }
        }
        public PdfResult(PdfDocument pdfDocument, string filename, HttpResponse respone, HttpReadType type)
        {
            this.m_pdfDocument = pdfDocument;
            this.m_pdfLoadedDocument = null;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
        }
        public PdfResult(PdfLoadedDocument pdfLoadedDocument, string filename, HttpResponse respone, HttpReadType type)
        {
            this.m_pdfDocument = null;
            this.m_pdfLoadedDocument = pdfLoadedDocument;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                return;
            if (pdfLoadedDoc != null)
                this.pdfLoadedDoc.Save(FileName, Response, ReadType);
            if (PdfDoc != null)
            {
                this.PdfDoc.Save(FileName, Response, ReadType);
                this.PdfDoc.Close(true);
            }
        }
    }   
}
