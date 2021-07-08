namespace Modul2HW2
{
   public class ProductProvider
    {
        public ProductProvider()
        {
            Products = new Product[21];
            Init();
        }

        public Product[] Products { get; }
        private void Init()
        {
            Products[0] = new Product("Картофель по-средиземноморски ", 55);
            Products[1] = new Product("Паста Болоньезе ", 99);
            Products[2] = new Product("Паста тальятелле 4 сыра ", 99);
            Products[3] = new Product("Нью Йорк бургер ", 165);
            Products[4] = new Product("Роял бургер ", 185);
            Products[5] = new Product("Чикен бургер ", 145);
            Products[6] = new Product("Цезарь ", 139);
            Products[7] = new Product("Греческий ", 109);
            Products[8] = new Product("Кайсо ", 69);
            Products[9] = new Product("Боул с гуакамоле и манго ", 115);
        }
    }
}
