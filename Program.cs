namespace DodoCake

{
    class Program
    {
        static void Main(string[] args)
        {
            Order userOrder = new Order();
            Cake orderedCake = userOrder.MakeOrder();

            string filePath = "C:\\Users\\hades\\source\\repos\\DodoCake\\история_заказов.txt";

            string[] orderOutput = new string[3];
            orderOutput[0] = $"Заказ от {DateTime.Now}";
            orderOutput[1] = $"\tЗаказ: {orderedCake.orderOutput}";
            orderOutput[2] = $"\tЦена: {orderedCake.totalCost}\n";

            File.AppendAllLines(filePath, orderOutput);
        }
    }
}