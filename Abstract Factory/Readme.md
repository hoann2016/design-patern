# Code Explanation
1. Định nghĩ đối tượng và method: 
- Động vật có 2 loại ăn cỏ (Herbivore) và ăn thịt, ăn thịt (Carnivore) có method eat với param là động vật ăn cỏ

2. Abstract class factory: 
- Lục địa(ContinentFactory): chỉ khai báo 2 method là tạo động vật ăn cỏ và ăn thịt

3. Create class inherist from ABS class factory:
- Châu phi (AfricaFactory) kế thừa từ lục địa, implement 2 phương thức của abs class để tạo ra sư tử (Lion) và linh dương đầu bò (Wildebeest)
- Châu mỹ (AmericaFactory).... bò rừng (Bison) và sói (Wolf)

4. Sử dụng:
- Class Thế giới loài thú  với 2 thuộc tính về loài ăn cỏ và ăn thịt, hàm dựng clas này nhận 
1 tham số đầu vào là lục địa factory (ABS class) dùng để khởi tạo giá trị cho 2 thuộc tính trên, và có 
1 method là chuỗi thức ăn để thực hiện hàm eat.

Vấn đề ở đây là dù chúng ta có đưa vào châu phi hay châu mỹ thì các đối tượng sẽ khởi tạo và chạy 
method eat tương ứng với các châu lục, cụ thể:
nếu đầu vào là châu mỹ : object sói sẽ chạy method eat với param là bò rừng
.... châu phi: sư tử ... linh dương.  
Output  
`Lion eats Wildebeest
Wolf eats Bison`  
**Chốt, ABS class chính là 1 khuôn mẫu,đề xuất các method nên có, những nơi sử dụng Factory class này như một tham số
có thể nhận các class kế thừa từ abs class nên nó sẽ có những specify method tương ứng được thực thi**
