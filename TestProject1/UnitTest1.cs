namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CreateInstanceOfClass()
        {
            ToPDF instance = new ToPDF();
            Assert.IsType<ToPDF>(instance);
            instance.Dispose();
        }

        [Fact]
        public void ConvertOneWordFileToPDF()
        {
            string wordPath = "C:\\Users\\PC\\Desktop\\1.docx";
            string pdfPath = "C:\\Users\\PC\\Desktop\\1.pdf";
            ToPDF instance = new ToPDF();
            instance.WordToPDF(wordPath, pdfPath);
            Assert.True(File.Exists(pdfPath));
            File.Delete(pdfPath);
            instance.Dispose();
        }

        [Fact]
        public void ConvertOneFileToPDFInUsingConstraction()
        {
            using (ToPDF instance = new ToPDF())
            {
                string wordPath = "C:\\Users\\PC\\Desktop\\2.docx";
                string pdfPath = "C:\\Users\\PC\\Desktop\\2.pdf";
                instance.WordToPDF(wordPath, pdfPath);
                Assert.True(File.Exists(pdfPath));
                File.Delete(pdfPath);
            }
        }

        [Fact]
        public void DisposeInstanceOfClass()
        {
            ToPDF instance = new ToPDF();
            instance.Dispose();
            Assert.True(instance.IsDisposed);
        }

        [Fact]
        public void UseInstanceOfClassAfterDispose()
        {
            ToPDF instance = new ToPDF();
            instance.Dispose();
            string wordPath = "C:\\Users\\PC\\Desktop\\2.docx";
            string pdfPath = "C:\\Users\\PC\\Desktop\\2.pdf";
            Assert.Throws<ObjectDisposedException>(() => instance.WordToPDF(wordPath, pdfPath));
        }
    }
}