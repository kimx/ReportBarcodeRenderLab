using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
namespace ReportBarcodeRenderLab
{
    public class BarcodeProxy
    {
        private BarcodeLib.Barcode Barcode;
        public BarcodeProxy()
        {
            this.Barcode = new BarcodeLib.Barcode();
        }
        public byte[] Render(string value)
        {
            Barcode.Alignment = BarcodeLib.AlignmentPositions.CENTER;
            Barcode.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
            Barcode.IncludeLabel = true;
            Barcode.AlternateLabel = value;
            Barcode.RotateFlipType = RotateFlipType.Rotate180FlipXY;
            var image = Barcode.Encode(BarcodeLib.TYPE.CODE128A, value, Color.Black, Color.White, 250, 90);
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}