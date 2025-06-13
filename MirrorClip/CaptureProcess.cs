using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MirrorClip
{
    class CaptureProcess
    {
        Thread TaskThread = null;
        public bool isRunning = true;
        public void close()
        {
            this.isRunning = false;
            if (TaskThread.ThreadState == ThreadState.Running)
            {
                TaskThread.Join();
            }
        }
        void MainThread()
        {
            while (this.isRunning)
            {

            }
        }
    }
}
