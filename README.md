# :chart: Expense Manager

Desktop expense manager built on top of [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-6.0&preserve-view=true) using the awesome [C#](https://learn.microsoft.com/en-us/dotnet/csharp/) language.

:white_check_mark: Made as a little project for the Programming 1 subject at uni.

![Imgur](https://imgur.com/3Tw604G.jpg)

## Getting started
<!-- TODO Note to self: uncomment this when you actually get to publishing the application. -->
<!-- ### Download from the release tab
The lazy option. Boring. -->

### Build it yourself
Requirements: 
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)  
- [Visual Studio](https://visualstudio.microsoft.com/)

Steps:
1. Clone this repository: `git clone https://github.com/dariomrk/WinForms-Expense-Manager.git`.
2. Open the project solution file: `WinForms-Expense-Manager.sln`.
3. Set the build configuration to `Release`.
4. Build and run: `ctrl + F5`.

## Features
- Adding, removing and modifying expense / income entries.
- Adding, removing and modifying categories.
- Filtering entries by:
  - time of creation
  - type of entry
  - category
- Summary:
  - Totals from all data
  - Totals from filtered data
- Exporting as .csv for that sweet Excel / Sheets support

## A bit about the inner workings
- Entries are defined with the following properties:
    - Id
    - Title, Description
    - Value
    - Category id
    - Time of creation
- Categories are defined as a dictionary:
  - Id
  - Name
- Class ExpenseManager provides an abstraction over these two constructs. It contains methods that allow data handling, data storage, data sanitation and data validation.
