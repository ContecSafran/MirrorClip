using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MirrorClip
{
    public class ScreenCapture
    {
        int MonitorAreaIndex = 0;
        public int imageData_Stride;
        public PixelFormat pixelFormat;
        public bool IsCaptureStart = true;   //false : Receive
        public bool Stop = true;
        public Bitmap bmp;
        public byte[] Buffer = null;
        public System.Drawing.Point CaptureStartPoint = new Point(0,0);
        public System.Drawing.Size CaptureSize = new Size(300,100);
        public ScreenCapture()
        {
            // 픽셀 포맷 정보 얻기 (Optional)
            int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
            pixelFormat = PixelFormat.Format32bppArgb;
            if (bitsPerPixel <= 16)
            {
                pixelFormat = PixelFormat.Format16bppRgb565;
            }
            if (bitsPerPixel == 24)
            {
                pixelFormat = PixelFormat.Format24bppRgb;
            }
        }
        public void Init(int x, int y, int w, int h)
        {
            // 화면 크기만큼의 Bitmap 생성
            CaptureStartPoint = new Point(x, y);
            bmp = new Bitmap(w, h, pixelFormat);
        }

        public void Capture()
        {
            int index = MonitorAreaIndex;
            // Bitmap 이미지 변경을 위해 Graphics 객체 생성
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                // 화면을 그대로 카피해서 Bitmap 메모리에 저장
                //gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
                gr.CopyFromScreen(CaptureStartPoint.X, CaptureStartPoint.Y,0, 0, CaptureSize);
            }
        }
        public void CaptureBuffer()
        {
            IsCaptureStart = true;
            Capture();
            BitmapToArray();
        }
        public void BitmapToArray()
        {
            var imageData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                                ImageLockMode.ReadWrite, pixelFormat);
            if (Buffer == null)
            {
                imageData_Stride = imageData.Stride;
                Buffer = new byte[imageData.Height * imageData.Stride];
            }
            try
            {
                Marshal.Copy(imageData.Scan0, Buffer, 0, Buffer.Length);
            }
            finally
            {
                bmp.UnlockBits(imageData);
            }
        }


        public void ArrayToBitmap()
        {
            BitmapData imageData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                                ImageLockMode.ReadWrite, pixelFormat);
            try
            {
                Marshal.Copy(Buffer, 0, imageData.Scan0, Buffer.Length);
            }
            finally
            {
                bmp.UnlockBits(imageData);
            }
        }
    }
}
