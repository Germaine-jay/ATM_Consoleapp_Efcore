# GERMANE Bank ATM Console Application with EFCORE 😎
#### This is a console application that mimics the functionalities of a modern-day ATM application, built with C#. Designedesigned using object-oriented programming(OOP) construct and SQLServer database.

## Tools Used 👌
* Project type
* SQL: SQLServer
* Language: C#
* Microsoft Entity Framework core(EFCore):
> - *Microsoft Entity Framework core Design V 6.0.1*
> - *Microsoft Entity Framework core Tools V 6.0.1*
> - *Microsoft Entity Framework core SqlServer V 6.0.1*

## Basic Features 👌
* Check Balance
* Transfer Funds(Transfer within the same bank but different account number)
* Make Withdrawal
* Buy Airtime
* Reset Account Pin

## How to Use
* Clone Repository: **git clone https://github.com/Germaine-jay/ATM_Consoleapp_Efcore.git**
* Copy your DataBase connection string and paste it into the AtmDbContextFactory class.

## Default Customers
![default customer table](../Pictures/tablepic.jpg)
![default accounts table](../Pictures/tablepic2.jpg)

## Note
* Change your pin from the default pin carrying out your first transaction
* All account balances start with #0
* Maximum withdrawal amount is #20,000 per transaction
* Maximum Transfer amount is a million Naira

## Assumptions
* All Users are customers of same bank.
