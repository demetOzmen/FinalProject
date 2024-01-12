namespace Business.CCC
{
    //public ProductManager(IProductDal productDal)
    //{
    //    _productDal = productDal;
    //}
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
