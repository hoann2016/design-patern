# Code explanation
giả sử code ban đâu là
```
 abstract class Shape
    {
        public Color color { get; set; }

        public abstract string GetColor()
    }

    class Square : Shape
    {
        public override string GetColor()
        {
            return color.GetColor();
        }
    }

    class Circle : Shape
    {
        public override  string GetColor()
        {
            return color.GetColor();
        }
    }
```
Mối quan hệ giữa các class kế thừa từ shape và color chưa được tập trung => khó mở rộng nếu thêm nhiều color

**Bridge ở đây là class Shape, đóng vai trò là nơi thiết lập cầu nối cho các class implementation or heristance và các đối tượng cần mở rộng.**
