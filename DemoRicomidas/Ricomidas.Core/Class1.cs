using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Ricomidas.Core
{

    public class PDfService
    {


        //new FileStream(path, FileMode.Create)
        public void GetReporte(Stream stream)
        {
            var pageSize = PageSize.LETTER;
            
            Document doc = new Document(pageSize);
            // step 2:
            // we create a writer that listens to the document
            // and directs a PDF-stream to a file
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc,stream);

            doc.Open();

            ////fonts
            //var titleFont = GetFont();
            //titleFont.SetStyle(Font.BOLD);
            //titleFont.Color = BaseColor.BLACK;
            //var font = GetFont();
            //var attributesFont = GetFont();
            //attributesFont.SetStyle(Font.ITALIC);

            //int ordCount = orders.Count;
            //int ordNum = 0;

            //// step 3: we open the document
            //document.Open();

            //// step 4: we create a table and add it to the document
            //Table aTable = new Table(2, 2);    // 2 rows, 2 columns
            //aTable.AddCell("0.0");
            //aTable.AddCell("0.1");
            //aTable.AddCell("1.0");
            //aTable.AddCell("1.1");
            //document.Add(aTable);

            //bRet = true;

        }

    }

}
