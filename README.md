# Lab02_ATM Machine and Unit_Testing
C# ATM console app with unit testing and error handling concepts applied.

## Dependencies
This ATM console app runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab02_Unit_Testing
dotnet restore
dotnet run
```
---
## Program Overwiew
This console app is an exercise in working with C# fundamentals as well as unit testing and error handling.
This ATM gives a user 4 choices: Deposit, Withdraw, View Balance and Exit. Invalid inputs will require the user to select again or input a valid format.
Unit tests tests for a few scenarios that are dependent on user input.

---
## How to Use the Program
Firstly, choose one of the 4 choices: Deposit, Withdraw, View Balance and Exit.

Choosing 'Deposit' will allow a user to deposit.
A user cannot deposit negative amounts, but positive inputs are valid.

Choosing 'Withdraw' will allow a user to withdraw.
A user cannot withdraw more than what they have, but amounts less than their balance are valid.

Choosing 'View Balance' will allow a user to view their balance.

Choosing 'Exit' will exit the program.  If a user selects any of the other 3 options, they will be prompted with the main menu after they've completed their other transactions.  

---

## Screenshots
Main Menu:
![menu](https://raw.githubusercontent.com/jcqnly/Lab02_Unit_Testing/master/assets/menu.png)
Deposit:
![deposit](https://raw.githubusercontent.com/jcqnly/Lab02_Unit_Testing/master/assets/deposit.png)
Withdraw:
![withdraw](https://raw.githubusercontent.com/jcqnly/Lab02_Unit_Testing/master/assets/withdraw.png)