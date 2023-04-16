/* Registration */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'REGISTRATION') BEGIN SELECT id FROM REGISTRATION ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE REGISTRATION(id int, company_name nvarchar(20),username nvarchar(20), password nvarchar(18), re_password nvarchar(18), address nvarchar(500), mobile_no numeric(10,0), city nvarchar(30), state nvarchar(30), pincode int, gst_no nvarchar(15), pancard nvarchar(10), adhaar_no numeric(12,0), upi_no nvarchar(18), bank_name nvarchar(100), acc_no numeric(15,0), ifsc_code nvarchar(11), acc_type nvarchar(20), primary key(company_name)); PRINT 'Table does not exist.' END

/* add account */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_ACCOUNT') BEGIN SELECT id FROM ADD_ACCOUNT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no numeric(10,0), pan nvarchar(10), aadhaar numeric(12,0), gst_no nvarchar(15), acc_add_date date, primary key(acc_name)); PRINT 'Table does not exist.' END

/* add product */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_PRODUCT') BEGIN SELECT id FROM ADD_PRODUCT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_PRODUCT(id int, brand nvarchar(50), product_name nvarchar(100), product_Price float, stock int, retail_price int, weight_ int, weight_size nvarchar(10), product_picture image, primary key(id)); PRINT 'Table does not exist.' END
/* add product insert query */
INSERT INTO ADD_PRODUCT(id, brand, product_name, product_Price, stock, retail_price, weight_, weight_size, product_picture) VALUES(1, "gg", "gfh", 100, 00, 120, 100, "gm", "C:\Users\Ary patel\Pictures\ary\mummy's photos\ary\IMG_3230")


SELECT acc_name FROM dbo.ADD_ACCOUNT where type_of_customer = 'Supplier'