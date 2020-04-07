
namespace Encryption_DES
{
    class Cryptographer
    {
        CommonProcess cProcess = null;

        public Cryptographer(int algorithm_number, Form1.ProgressEventHandler IncrementProgress, Form1.ProgressInitHandler InitProgress)
        {
            if (Algorithms.DES == algorithm_number || Algorithms.DES_File == algorithm_number)
            {
                cProcess = new DES.ProcessDES(IncrementProgress, InitProgress);
            }
        }

        public void EncryptionStart(string filename, string EncryptedFilename, string key)
        {
            string binarytext = AES.FileIO.FileReadToBinary(filename);
            binarytext = this.EncryptionStart(binarytext, key, true);
            AES.FileIO.WriteBinaryToFile(EncryptedFilename, binarytext);
        }

        public string EncryptionStart(string text, string key, bool IsBinary)
        {
            return cProcess.EncryptionStart(text, key, IsBinary);
        }

        public void DecryptionStart(string filename, string DecryptedFilename, string key)
        {
            string binarytext = AES.FileIO.FileReadToBinary(filename);
            binarytext = this.DecryptionStart(binarytext, key, true);
            AES.FileIO.WriteBinaryToFile(DecryptedFilename, binarytext);
        }

        public string DecryptionStart(string text, string key, bool IsBinary)
        {
            return cProcess.DecryptionStart(text, key, IsBinary);
        }
    }
}
