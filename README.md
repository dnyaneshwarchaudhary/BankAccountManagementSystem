The "BankAccountManagementSystem" is a C# project designed to facilitate the management of bank accounts. It includes a base class called "Account" with essential data members and methods, which is then extended to create two specialized account types: "SavingsAccount" and "CurrentAccount."

The core features of this project include:

Account Class: This class serves as the foundation for all bank accounts, featuring data members such as account number, account holder name, balance, ISBN number (static), and rate of interest (static). It also provides methods for initializing, displaying, accepting input, and calculating the balance for various types of accounts.

SavingsAccount Class: Derived from the "Account" class, this subclass incorporates additional data members like saving interest. It overrides methods from the base class to accommodate specialized calculations and provide a customized user experience for savings accounts.

CurrentAccount Class: Similar to "SavingsAccount," the "CurrentAccount" class extends the "Account" class with unique data members, such as current charges. It also overrides methods to handle specific operations for current accounts.

This project aims to demonstrate object-oriented programming principles, including inheritance and method overriding, to create a robust bank account management system that can handle different types of accounts efficiently. It offers a foundation for further expansion and customization to meet the specific needs of a banking application.
