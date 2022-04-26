USE [AddressBookServiceDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure GetContactDetails
As
Begin

SELECT AddressBook_ID,FirstName,SecondName,Address,City,State,Zip,PhoneNumber,Email,ContactType_Name
from Address_Book
Left JOIN Contact_Person on Address_Book.Address_BookID=AddressBook_ID 
Left JOIN TypeManager on TypeManager.Contact_Identity=Contact_ID
Left JOIN ContactType on TypeManager.ContactType_Identity=ContactType_ID
end