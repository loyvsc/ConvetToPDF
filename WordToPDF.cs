using System;
using System.Threading;
using System.Threading.Tasks;

namespace wtpdf
{
    public class ToPDF : IDisposable
    {        
        private Microsoft.Office.Interop.Word.Application _msWordApp;
        public bool IsDisposed = false;

        public ToPDF()
        {            
            _msWordApp = new Microsoft.Office.Interop.Word.Application() { Visible = false };
        }

        public void WordToPDF(string wordFile, string outPath)
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException("ToPDF");
            }
            try
            {
                _msWordApp.Documents.Open(wordFile);
                _msWordApp.ActiveDocument.SaveAs(outPath, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);
                _msWordApp.Documents.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при конвертировании {wordFile}:{ex.Message}");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException("ToPDF");
            }
            if (disposing)
            {
                _msWordApp.Quit();
            }
            IsDisposed = true;
        }
    }
}