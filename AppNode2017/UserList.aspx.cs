using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//usamos los DLL
using Domain;
using Busines;
using System.IO;

//libreria para reportes
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.html;

namespace AppNode2017
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = UserBusiness.getUsers().ToList();
            GridView2.DataBind();
        }

        protected void udpate_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=ReporteUsuarios.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView2.AllowPaging = false;            
            GridView2.DataBind();
            GridView2.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());        
            Document pdfDoc = new Document(PageSize.A4, 10f,10f, 10f,0f);
            
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            
            pdfDoc.Open();
           
            //agregando una imagen
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/Users/Gustavo/Documents/GitHub/CoreVises/AppNode2017/img/tree.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_TOP;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 80 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            //insertamos la imagen
            pdfDoc.Add(imagen);
                    
            pdfDoc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
            string date = "Fecha:" + DateTime.Now.ToString();
            Chunk chunk = new Chunk("Reporte  General Usuarios", FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD));
            pdfDoc.Add(new Paragraph(chunk));
            pdfDoc.Add(new Paragraph("Paraiso,Cartago,Costa Rica"));            
            pdfDoc.Add(new Paragraph(date));
            pdfDoc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
            pdfDoc.Add(new Paragraph("                       "));
         
         

            htmlparser.Parse(sr);
              
            pdfDoc.Close();
            
            Response.Write(pdfDoc);
            Response.End();



        }

        public override void VerifyRenderingInServerForm(Control control)
        { }
    }
}