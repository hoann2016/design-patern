# Code explanation
PizzaProvider cung cấp các loại piza và BreadProvider cung cấp các loại bánh mì, 
cửa hàng RestaurantFacade sử dụng 2 interface này để build các chức năng có liên kết của bánh mì và pizza

**Tóm lại: facade restaurant cung cấp 1 giao diện đơn giản hơn, nếu trường hợp như bánh mì hay pizza
có rất nhiều method không cần thiết. Facade Class làm nhiệm vụ collect từ nhiều interface ra một class đơn giản hơn**
