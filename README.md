## DB schemas

### Product
- GUID id(PK) 
- GUID productId
- varchar(100) name
- varchar(200) description
- decimal(10,4) price
- GUID categoryID(FK)
- int quantity

### Category
- GUID categoryID(PK)
- varchar(100) name
- varchar(100) type
