# Code Explanation
 Subject (Stock) mặc định sẽ có 3 method: attach, detach, notify
 ConcreteSubject (IBM) kế thừa từ subject sẽ có 1 thuộc tính SubjectState
 new Investor("Sorros") và new Investor("Berkshire") đóng vai trò là concrete observer
Khi các con concrete subject update price, thì các concrete observer nhận được notify tương ứng.
Mà ở đây, logic của update (Notify) sẽ được để trong các Concrete Observer
```Concrete subject ->Price Setter --> Notify-->Loop Update() cho các inverter```
investor.Update(this) =>pass current instance: Stock into method Update in Concrete Observer to get current value of Price property
**Update notification cho các concrete observer đăng ký lăng nghe subject**