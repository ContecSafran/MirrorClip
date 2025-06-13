using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorClip
{
    class OverlayForm : Form
    {
        // 윈도우 스타일 상수
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = -20;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public Bitmap drawBitmap = null;
        public OverlayForm()
        {

            this.FormBorderStyle = FormBorderStyle.None; // 테두리 제거
            this.TopMost = true;                         // 항상 위
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 표시
            this.ShowInTaskbar = false;                  // 작업표시줄 숨기기
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Opacity = 0.8; // 0.0 ~ 1.0 (투명 ~ 불투명)

            // 클릭 투명 처리 적용
            this.Load += (s, e) =>
            {
                int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
                SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle | WS_EX_LAYERED | WS_EX_TRANSPARENT);
            };
        }
        public void reDraw(Bitmap bmp)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((System.Action)delegate
                {
                    reDraw(bmp);
                });
            }
            else
            {
                this.BackgroundImage = bmp;
                this.Invalidate();
            }
        }
    }
}
