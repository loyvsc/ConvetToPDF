namespace Tests
{
    [TestClass]
    public class ToPDFTest
    {
        [TestMethod]
        public void CreateClass()
        {
            ToPDF topdf = new ToPDF();
            Assert.IsInstanceOfType(topdf, Type.GetType("ToPDF"));
        }

        [TestMethod]
        public void DisposeClass()
        {
            ToPDF topdf = new ToPDF();
            topdf.Dispose();            
            Assert.IsNull(topdf);
        }
    }
}