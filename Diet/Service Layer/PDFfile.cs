using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.Business_Layer;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Diet.Service_Layer
{
    class PDFfile
    {
        public static void save(List<Meal> meals, Label label1, Label label2)
        {
            if (Convert.ToDouble(label1.Text) < Convert.ToDouble(label2.Text)) { return; }
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Diet";
            PdfPage pdfPage = pdf.AddPage();

            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            XFont font1 = new XFont("Times New Roman", 12, XFontStyle.Bold, options);
            XFont font2 = new XFont("Times New Roman", 14, XFontStyle.Bold);
            XFont font3 = new XFont("Castellar", 25, XFontStyle.Bold);

            int i = 3;
            graph.DrawString("Diet Page", font3, XBrushes.BlueViolet, new XPoint(230, 20));
            foreach (Meal meal in meals)
            {
                string name = meal.NameOfMeal;
                graph.DrawString(name, font2, XBrushes.Red, new XPoint(50, i * 20));
                XPen lineRed = new XPen(XColors.Purple, 1);
                graph.DrawLine(lineRed, 0, (i) * 20 + 5, pdfPage.Width, (i) * 20 + 5);
                i++;
                foreach (ProductUsed productUsed in meal.ProductsUsed)
                {
                    graph.DrawString(productUsed.Name + " " + productUsed.Gramms + "gramms", font1, XBrushes.Blue,
                        new XPoint(100, i * 20));
                    graph.DrawLine(lineRed, 0, (i) * 20 + 5, pdfPage.Width, (i) * 20 + 5);
                    i++;
                }
            }
            graph.DrawString("Total Calories: " + label2.Text, font2, XBrushes.Green, new XPoint(230, (i+1) * 20));
            string pdfFilename = "Diet.pdf";
            pdf.Save(pdfFilename);
            System.Diagnostics.Process.Start(pdfFilename);
        }
    }
}
