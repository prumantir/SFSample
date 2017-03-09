using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Drawing;
using System.IO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System.Data;
namespace SFSample
{
    public partial class DocIOController : Controller
    {
          public ActionResult DocIOFeatures(string Group1)
          {
            if (Group1 == null)
                return View();
            string dataPath3 = ResolveApplicationDataPath("", "Content\\Images\\DocIO");
            //A new document is created.
            WordDocument document = new WordDocument();
            //Adding a new section to the document.
            WSection section = document.AddSection() as WSection;
            //Set Margin of the section
            section.PageSetup.Margins.All = 72;
            //Set page size of the section
            section.PageSetup.PageSize = new SizeF(612, 792);
            //Create Paragraph styles
            WParagraphStyle style = document.AddParagraphStyle("Normal") as WParagraphStyle;
            style.CharacterFormat.FontName = "Calibri";
            style.CharacterFormat.FontSize = 11f;
            style.ParagraphFormat.BeforeSpacing = 0;
            style.ParagraphFormat.AfterSpacing = 8;
            style.ParagraphFormat.LineSpacing = 13.8f;
            style = document.AddParagraphStyle("Heading 1") as WParagraphStyle;
            style.ApplyBaseStyle("Normal");
            style.CharacterFormat.FontName = "Calibri Light";
            style.CharacterFormat.FontSize = 16f;
            style.CharacterFormat.TextColor = Color.FromArgb(46, 116, 181);
            style.ParagraphFormat.BeforeSpacing = 12;
            style.ParagraphFormat.AfterSpacing = 0;
            style.ParagraphFormat.Keep = true;
            style.ParagraphFormat.KeepFollow = true;
            style.ParagraphFormat.OutlineLevel = OutlineLevel.Level1;
            //Appends paragraph.
            IWParagraph paragraph = section.AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            WTextRange textRange = paragraph.AppendText("Syncfusion Metro Studio") as WTextRange;
            textRange.CharacterFormat.FontSize = 18f;
            textRange.CharacterFormat.FontName = "Calibri";
            //Appends paragraph.
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.FirstLineIndent = 36;
            //Appends paragraph.
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.FirstLineIndent = 36;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            textRange = paragraph.AppendText("Syncfusion Metro Studio is a collection of over 1700 Metro-style icon templates that can be easily customized to create thousands of unique Metro icons. Metro is a design language so it can be applied to any platform or technology. At Syncfusion we have used these icons in everything from PowerPoint presentations to applications written in all .NET platforms including WPF, Silverlight, Windows Phone, Windows Forms, ASP.NET, and ASP.NET MVC.") as WTextRange;
            textRange.CharacterFormat.FontSize = 12f;
            #region Insert Table.
            //Appends table.
            IWTable table = section.AddTable();
            table.ResetCells(3, 2);
            table.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.None;
            table.TableFormat.IsAutoResized = true;
            //Appends paragraph.
            paragraph = table[0, 0].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            //Appends picture to the paragraph.
            WPicture picture = paragraph.AppendPicture(Image.FromFile(System.IO.Path.Combine(dataPath3, "MetroStudio1.png"))) as WPicture;
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
            picture.VerticalOrigin = VerticalOrigin.Paragraph;
            picture.VerticalPosition = 0;
            picture.HorizontalOrigin = HorizontalOrigin.Column;
            picture.HorizontalPosition = -5.15f;
            picture.WidthScale = 79;
            picture.HeightScale = 79;
            //Appends paragraph.
            paragraph = table[0, 1].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.AppendText("Developer-friendly icon editor ");
            //Appends paragraph.
            paragraph = table[0, 1].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            paragraph.BreakCharacterFormat.FontName = "Times New Roman";
            textRange = paragraph.AppendText("Metro Studio includes a powerful icon editor that lets you quickly find and customize all the icons that you need in only a few minutes. ") as WTextRange;
            textRange.CharacterFormat.FontSize = 12f;
            textRange.CharacterFormat.FontName = "Times New Roman";
            //Appends paragraph.
            paragraph = table[0, 1].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            //Appends paragraph.
            paragraph = table[1, 0].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.AppendText("Convert fonts to icons ");
            //Appends paragraph.
            paragraph = table[1, 0].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            paragraph.BreakCharacterFormat.FontName = "Times New Roman";
            textRange = paragraph.AppendText("Easily customize thousands of font characters as icons and export them to the desired formats. ") as WTextRange;
            textRange.CharacterFormat.FontSize = 12f;
            textRange.CharacterFormat.FontName = "Times New Roman";
            //Appends paragraph.
            paragraph = table[1, 0].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            //Appends paragraph.
            paragraph = table[1, 1].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.LineSpacing = 12f;
            //Appends picture to the paragraph.
            picture = paragraph.AppendPicture(Image.FromFile(System.IO.Path.Combine(dataPath3, "MetroStudio2.png"))) as WPicture;
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
            picture.VerticalOrigin = VerticalOrigin.Paragraph;
            picture.VerticalPosition = 8.2f;
            picture.HorizontalOrigin = HorizontalOrigin.Column;
            picture.HorizontalPosition = -14.95f;
            picture.WidthScale = 75;
            picture.HeightScale = 75;
            //Appends paragraph.
            paragraph = table[2, 0].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.LineSpacing = 12f;
            //Appends picture to the paragraph.
            picture = paragraph.AppendPicture(Image.FromFile(System.IO.Path.Combine(dataPath3, "MetroStudio3.png"))) as WPicture;
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
            picture.VerticalOrigin = VerticalOrigin.Paragraph;
            picture.VerticalPosition = 0;
            picture.HorizontalOrigin = HorizontalOrigin.Column;
            picture.HorizontalPosition = -4.9f;
            picture.WidthScale = 92;
            picture.HeightScale = 92;
            //Appends paragraph.
            paragraph = table[2, 1].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.AppendText("Organize icons as projects ");
            //Appends paragraph.
            paragraph = table[2, 1].AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 0;
            paragraph.ParagraphFormat.LineSpacing = 12f;
            paragraph.BreakCharacterFormat.FontSize = 12f;
            paragraph.BreakCharacterFormat.FontName = "Times New Roman";
            textRange = paragraph.AppendText("Organize icons into projects that can be serialized for modification at a later time. Multiple icons in a project can be exported with a single click. ") as WTextRange;
            textRange.CharacterFormat.FontSize = 12f;
            textRange.CharacterFormat.FontName = "Times New Roman";
            //Appends paragraph.
            paragraph = table[2, 1].AddParagraph();
            paragraph.ApplyStyle("Heading 1");
            paragraph.ParagraphFormat.LineSpacing = 12f;
            #endregion
            //Appends paragraph.
            section.AddParagraph();
            #region saveOption
            if (Group1 == "Word97To2003")
            {
                //Save as .doc Word 97-2003 format
                return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx Word 2007 format
            else if (Group1 == "Word2007")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Word2007, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx Word 2010 format
            else if (Group1 == "Word2010")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Word2010, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx Word 2013 format
            else if (Group1 == "Word2013")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Word2013, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            #endregion saveOption
            return View();
        }
        protected string ResolveApplicationDataPath(string fileName, string folderName)
        {
            string dataPath = new System.IO.DirectoryInfo(Request.PhysicalApplicationPath).FullName;
            if (folderName != string.Empty)
                dataPath += folderName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
    }
}
    #region DocumentResult
    /// <summary>
    /// This Class represents the Custom ActionResult for WordDocument.
    /// </summary>
    public class DocumentResult : ActionResult
    {
        #region Fields
        private string m_filename;
        private IWordDocument m_document;
        private FormatType m_formatType;
        private HttpResponse m_response;
        private HttpContentDisposition m_contentDisposition;
        #endregion Fields
        #region Properties
        /// <summary>
        /// Gets/Sets the Name of the file.
        /// </summary>
        /// <value>Name of the file</value>
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
        /// <summary>
        /// Gets the WordDocument
        /// </summary>
        /// <value>The WordDocument</value>
        public IWordDocument Document
        {
            get
            {
                if (m_document != null)
                    return m_document;
                return null;
            }
        }
        /// <summary>
        /// Gets/Sets the Format Type
        /// </summary>
        /// <value>The FormatType</value>
        public FormatType formatType
        {
            get
            {
                return m_formatType;
            }
            set
            {
                m_formatType = value;
            }
        }
        /// <summary>
        /// Gets/Sets the type of ContentDisposition
        /// </summary>
        /// <value>The type of the ContentDisposition.</value>
        public HttpContentDisposition ContentDisposition
        {
            get
            {
                return m_contentDisposition;
            }
            set
            {
                m_contentDisposition = value;
            }
        }
        /// <summary>
        /// Gets the response
        /// </summary>
        /// <value>The Response.</value>
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        #endregion Properties
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentResult"/> class.
        /// </summary>
        /// <param name="document">The Word Document</param>
        /// <param name="filename">The Filename</param>
        /// <param name="formattype">The FormatType</param>
        /// <param name="response">The Resposne</param>
        /// <param name="contentDisposition">The Type of ContentDisposition</param>
        public DocumentResult(IWordDocument document, string filename, FormatType formattype, HttpResponse response, HttpContentDisposition contentDisposition)
        {
            FileName = filename;
            m_document = document;
            this.formatType = formattype;
            m_response = response;
            this.ContentDisposition = contentDisposition;
        }
        #endregion Constructor
        #region Implementation
        /// <summary>
        /// Executes the result.
        /// </summary>
        /// <param name="context">The Context.</param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context");
            this.Document.Save(FileName, formatType, Response, ContentDisposition);
        }
        #endregion Implementation
    }
    #endregion
    #region DocIOExtension
    /// <summary>
    /// DocIO Extension
    /// </summary>
    public static class DocIOExtension
    {
        /// <summary>
        /// Export the document as ActionResult, returns the DocResult
        /// </summary>
        /// <param name="document">WordDocument to serialize</param>
        /// <param name="filename">Name of the File</param>
        /// <param name="formattype">Format type of the document</param>
        /// <param name="response">Response</param>
        /// <param name="contentDisposition">HttpContentDisposition</param>
        /// <returns></returns>
        public static DocumentResult ExportAsActionResult(this IWordDocument document, string filename, FormatType formattype, HttpResponse response, HttpContentDisposition contentDisposition)
        {
            return new DocumentResult(document, filename, formattype, response, contentDisposition);
        }
    }
#endregion
