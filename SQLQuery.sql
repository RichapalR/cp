UPDATE Registration SET password = 1234 , re_password = 1234 WHERE pancard = 'HHJG' AND adhaar_no = 'JGJM' AND username = 'gf';

--add_account create query
CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name));

--delete table
DROP DATABASE Customer


--create table if not exists
USE [dball]
GO
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = N'ADD_ACCOUNT')
BEGIN
SELECT ID FROM ADD_ACCOUNT WHERE ID = 1
PRINT 'Table exists.'
END
ELSE
BEGIN
CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name));
PRINT 'Table does not exist.'
END


-- SELECT DATA START WITH SELECTED LETTER
select acc_name from ADD_ACCOUNT WHERE acc_name LIKE '%'

SELECT id, product_name from dbo.ADD_PRODUCT where brand = 'SHREE'
SELECT id, weight_, weight_size, product_Price FROM dbo.ADD_PRODUCT where product_name = 'CEM'
SELECT DISTINCT brand from dbo.ADD_PRODUCT

SELECT DISTINCT brand, id FROM dbo.ADD_PRODUCT

/* Registration */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'REGISTRATION') BEGIN SELECT id FROM REGISTRATION ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE REGISTRATION(id int, company_name nvarchar(20),username nvarchar(20), password nvarchar(18), re_password nvarchar(18), address nvarchar(500), mobile_no int, city nvarchar(30), state nvarchar(30), pincode int, gst_no nvarchar(15), pancard nvarchar(10), adhaar_no int, upi_no nvarchar(18), bank_name nvarchar(100), acc_no int, ifsc_code nvarchar(11), acc_type nvarchar(20), primary key(company_name)); PRINT 'Table does not exist.' END

/* add account */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_ACCOUNT') BEGIN SELECT id FROM ADD_ACCOUNT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name)); PRINT 'Table does not exist.' END

/* add product */
use [C:\USERS\ARY PATEL\DOWNLOADS\NEW FOLDER\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_PRODUCT') BEGIN SELECT id FROM ADD_PRODUCT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_PRODUCT(id int, brand nvarchar(50), product_name nvarchar(100), product_Price float, stock int, retail_price int, weight_ int, weight_size nvarchar(10), product_picture image, primary key(id)); PRINT 'Table does not exist.' END
/* add product insert query */
INSERT INTO ADD_PRODUCT(id, brand, product_name, product_Price, stock, retail_price, weight_, weight_size, product_picture) VALUES(1, "gg", "gfh", 100, 00, 120, 100, "gm", "C:\Users\Ary patel\Pictures\ary\mummy's photos\ary\IMG_3230")

insert into account(name, amount, remark) values(@name, @amount, @remark);

select * from supplier_bill
