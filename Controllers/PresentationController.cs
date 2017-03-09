using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Syncfusion.Presentation;
namespace SFSample
{
    public class PresentationController : Controller
    {
        public ActionResult PresentationFeatures(string button)
        {
            if (button == null)
                return View();
            if (button == "Generate")
            {
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Create();
                //Method call to create slides
                CreateSlide101(presentation);
                CreateSlide201(presentation);
                CreateSlide301(presentation);
                CreateSlide401(presentation);
                return new PresentationResult(presentation, "Slides.pptx", HttpContext.ApplicationInstance.Response);
            }
            return View();
        }
        # region Slide1
        private void CreateSlide101(IPresentation presentation)
        {
            //Adds new slide to the presentation.
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.Title);
            //Retrieves the first shape of the slide.
            IShape shape1 = slide1.Shapes[0] as IShape;
            //Sets the shape left position value.
            shape1.Left = 1.5 * 72;
            //Sets teh top position value.
            shape1.Top = 1.94 * 72;
            //Sets the width value.
            shape1.Width = 10.32 * 72;
            //SEts the height value.
            shape1.Height = 2 * 72;
            //Retrieves the textbody of the shape.
            ITextBody textFrame1 = shape1.TextBody;
            //Retrieves the paragraph collection of the textframe.
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            //Adds new paragraph to the paragraph collection.
            IParagraph paragraph1 = paragraphs1.Add();
            //Adds new textpart to the paragraph.
            ITextPart textPart1 = paragraph1.AddTextPart();
            //Sets the indentlevelnumber.
            paragraphs1[0].IndentLevelNumber = 0;
            //Sets the Text to the textpart.
            textPart1.Text = "Essential Presentation";
            //Sets the font name.
            textPart1.Font.FontName = "HelveticaNeue LT 65 Medium";
            //Sets the font size.
            textPart1.Font.FontSize = 60;
            //Sets the bold property to true.
            textPart1.Font.Bold = true;
            //Removes the shape at the specified index.
            slide1.Shapes.RemoveAt(1);
        }
        #endregion
        # region Slide2
        private void CreateSlide201(IPresentation presentation)
        {
            //Adds a section header slide.
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.SectionHeader);
            //Retrieves the First shape of the slide.
            IShape shape1 = slide2.Shapes[0] as IShape;
            //Sets the value of the left position of the shape.
            shape1.Left = 0.77 * 72;
            //Sets the value of the top position of the shape.
            shape1.Top = 0.32 * 72;
            //Sets the Width of the shape.
            shape1.Width = 7.96 * 72;
            //Sets the height of the shape.
            shape1.Height = 0.99 * 72;
            //Retrieves the textbody of the shape.
            ITextBody textFrame1 = shape1.TextBody;
            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            IParagraph paragraph1 = paragraphs1.Add();
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraphs1[0].HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1.Text = "Slide with simple text";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";
            textpart1.Font.FontSize = 40;
            IShape shape2 = slide2.Shapes[1] as IShape;
            shape2.Left = 1.21 * 72;
            shape2.Top = 1.66 * 72;
            shape2.Width = 10.08 * 72;
            shape2.Height = 4.93 * 72;
            //To get textframe from shape
            ITextBody textFrame2 = shape2.TextBody;
            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs2 = textFrame2.Paragraphs;
            IParagraph paragraph2 = paragraphs2.Add();
            paragraph2.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextPart textpart2 = paragraph2.AddTextPart();
            textpart2.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus.";
            textpart2.Font.FontName = "Calibri (Body)";
            textpart2.Font.FontSize = 15;
            textpart2.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph3 = paragraphs2.Add();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph3.AddTextPart();
            textpart1.Text = "Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph4 = paragraphs2.Add();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph4.AddTextPart();
            textpart1.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph5 = paragraphs2.Add();
            paragraph5.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph5.AddTextPart();
            textpart1.Text = "Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et,";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph6 = paragraphs2.Add();
            paragraph6.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextPart textpart3 = paragraph6.AddTextPart();
            textpart1.Text = "nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla.";
            textpart1.Font.Color = ColorObject.White;
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph7 = paragraphs2.Add();
            paragraph7.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph7.AddTextPart();
            textpart1.Text = "Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla,";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph8 = paragraphs2.Add();
            paragraph8.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph8.AddTextPart();
            textpart1.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph9 = paragraphs2.Add();
            paragraph9.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph9.AddTextPart();
            textpart1.Text = "arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.Color = ColorObject.Black;
            textpart1.Font.FontSize = 15;
        }
        # endregion
        # region Slide3
        private void CreateSlide301(IPresentation presentation)
        {
            //Adds a two content slide to the presentation.
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.TwoContent);
            //Retrieves the first shape from the slide.
            IShape shape1 = slide2.Shapes[0] as IShape;
            //Sets the left position of the shape.
            shape1.Left = 0.36 * 72;
            //Sets the top position of the shape.
            shape1.Top = 0.51 * 72;
            //Sets the width of the shape.
            shape1.Width = 11.32 * 72;
            //Sets the height of the shape.
            shape1.Height = 1.06 * 72;
            //Adds textframe in shape
            ITextBody textFrame1 = shape1.TextBody;
            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            paragraphs1.Add();
            IParagraph paragraph1 = paragraphs1[0];
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;
            //Assigns value to textpart
            textpart1.Text = "Slide with Image";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";
            //Adds shape in slide
            IShape shape2 = slide2.Shapes[1] as IShape;
            //Adds textframe in shape
            ITextBody textFrame2 = shape2.TextBody;
            shape2.Left = 8.03 * 72;
            shape2.Top = 1.96 * 72;
            shape2.Width = 4.39 * 72;
            shape2.Height = 4.53 * 72;
            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs2 = textFrame2.Paragraphs;
            IParagraph paragraph2 = paragraphs2.Add();
            ITextPart textpart2 = paragraph2.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart2.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph3 = paragraphs2.Add();
            textpart2 = paragraph3.AddTextPart();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart2.Text = "Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;
            //Instance to hold paragraphs in textframe
            IParagraph paragraph4 = paragraphs2.Add();
            textpart2 = paragraph4.AddTextPart();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart2.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;
            IShape shape3 = (IShape)slide2.Shapes[2];
            slide2.Shapes.RemoveAt(2);
            //Adds picture in the shape
            string dataPath = Server.MapPath("~/App_Data");
            Stream imageStream = System.IO.File.Open(dataPath + "\\tablet.jpg", FileMode.Open);
            IPicture picture1 = slide2.Shapes.AddPicture(imageStream, 0.81 * 72, 1.96 * 72, 6.63 * 72, 4.43 * 72);
            imageStream.Close();
        }
        # endregion
        # region Slide4
        private void CreateSlide401(IPresentation presentation)
        {
            //Adds a two content slide to the presentation.
            ISlide slide4 = presentation.Slides.Add(SlideLayoutType.TwoContent);
            //Retrieves the shape from the slide.
            IShape shape1 = slide4.Shapes[0] as IShape;
            //Sets the left position of the shape.
            shape1.Left = 0.51 * 72;
            //Sets the top position of the shape.
            shape1.Top = 0.34 * 72;
            //Sets the width of the shape.
            shape1.Width = 11.32 * 72;
            //Sets the height of the shape.
            shape1.Height = 1.06 * 72;
            //Retrieves the textbody of the shape.
            ITextBody textFrame1 = shape1.TextBody;
            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            paragraphs1.Add();
            IParagraph paragraph1 = paragraphs1[0];
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;
            //Assigns value to textpart
            textpart1.Text = "Slide with Table";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";
            IShape shape2 = slide4.Shapes[1] as IShape;
            slide4.Shapes.Remove(shape2);
            //Adds a new table to the slide.
            ITable table = (ITable)slide4.Shapes.AddTable(6, 6, 0.81 * 72, 2.14 * 72, 11.43 * 72, 3.8 * 72);
            //Sets the height for the first row.
            table.Rows[0].Height = 0.85 * 72;
            table.Rows[1].Height = 0.42 * 72;
            table.Rows[2].Height = 0.85 * 72;
            table.Rows[3].Height = 0.85 * 72;
            table.Rows[4].Height = 0.85 * 72;
            table.Rows[5].Height = 0.85 * 72;
            //Sets whether table has banded rows.
            table.HasBandedRows = true;
            //Sets whether table has a header row.
            table.HasHeaderRow = true;
            //Sets whether table has a banded columns.
            table.HasBandedColumns = false;
            //Sets the builtin style for the table.
            table.BuiltInStyle = BuiltInTableStyle.MediumStyle2Accent1;
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell1 = table.Rows[0].Cells[0];
            ITextBody textFrame2 = cell1.TextBody;
            IParagraph paragraph2 = textFrame2.Paragraphs.Add();
            paragraph2.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart2 = paragraph2.AddTextPart();
            textPart2.Text = "ID";
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell2 = table.Rows[0].Cells[1];
            ITextBody textFrame3 = cell2.TextBody;
            IParagraph paragraph3 = textFrame3.Paragraphs.Add();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart3 = paragraph3.AddTextPart();
            textPart3.Text = "Company Name";
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell3 = table.Rows[0].Cells[2];
            ITextBody textFrame4 = cell3.TextBody;
            IParagraph paragraph4 = textFrame4.Paragraphs.Add();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart4 = paragraph4.AddTextPart();
            textPart4.Text = "Contact Name";
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell4 = table.Rows[0].Cells[3];
            ITextBody textFrame5 = cell4.TextBody;
            IParagraph paragraph5 = textFrame5.Paragraphs.Add();
            paragraph5.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart5 = paragraph5.AddTextPart();
            textPart5.Text = "Address";
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell5 = table.Rows[0].Cells[4];
            ITextBody textFrame6 = cell5.TextBody;
            IParagraph paragraph6 = textFrame6.Paragraphs.Add();
            paragraph6.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart6 = paragraph6.AddTextPart();
            textPart6.Text = "City";
            //Retrieves the cell and adds text content and other formattings to the text.
            ICell cell6 = table.Rows[0].Cells[5];
            ITextBody textFrame7 = cell6.TextBody;
            IParagraph paragraph7 = textFrame7.Paragraphs.Add();
            paragraph7.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart7 = paragraph7.AddTextPart();
            textPart7.Text = "Country";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "1";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "New Orleans Cajun Delights";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Shelley Burke";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "P.O. Box 78934";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "New Orleans";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[1].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "USA";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "2";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Cooperativa de Quesos 'Las Cabras";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Antonio del Valle Saavedra";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Calle del Rosal 4";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Oviedo";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[2].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Spain";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "3";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Mayumi";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Mayumi Ohno";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "92 Setsuko Chuo-ku";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Osaka";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[3].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Japan";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "4";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Pavlova, Ltd.";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Ian Devling";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "74 Rose St. Moonie Ponds";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Melbourne";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[4].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Australia";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "5";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Specialty Biscuits, Ltd.";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Peter Wilson";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "29 King's Way";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Manchester";
            //Retrieves the cell and adds text content and other formattings to the text.
            cell1 = table.Rows[5].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "UK";
            slide4.Shapes.RemoveAt(1);
        }
        #endregion
    }
  public class PresentationResult : ActionResult
    {
        private IPresentation m_source;
        private string m_filename;
        private HttpResponse m_response;
        private string m_separator;
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
        public IPresentation Source
        {
            get
            {
                return m_source as IPresentation;
            }
        }
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        public PresentationResult(IPresentation source, string fileName, HttpResponse response)
        {
            this.FileName = fileName;
            this.m_source = source;
            m_response = response;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context");
                this.m_source.Save(FileName, FormatType.Pptx,Response);
        }
    }
}
