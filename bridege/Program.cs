// Console.WriteLine("Tao doi tuong");
using Bridege;

var blue_color = new Blue();
var red_color = new Red();
Square blue_square = new Square { color = blue_color };
Square red_square = new Square { color = red_color };
Circle blue_circle = new Circle { color = blue_color };
Circle red_circle = new Circle { color = red_color };

Console.WriteLine($"Mau hinh chu nhat xanh: {blue_square.GetColor()}");
Console.WriteLine($"Mau hinh chu nhat do: {red_square.GetColor()}");
Console.WriteLine($"Mau hinh tron xanh: {blue_circle.GetColor()}");
Console.WriteLine($"Mau hinh tron do: {red_circle.GetColor()}");
