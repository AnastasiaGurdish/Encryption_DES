using System;

namespace Encryption_DES
{
    public class ProgressInitArgs : EventArgs
    {
        public ProgressInitArgs(int Maximum)
        {
            this.Maximum = Maximum;
        }

        public int Maximum;
    }

    public class ProgressEventArgs : EventArgs
    {
        public ProgressEventArgs(int Increment)
        {
            this.Increment = Increment;
        }

        public int Increment;
    }
}
