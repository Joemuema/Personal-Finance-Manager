# Personal Finance Manager (PFM)

A Windows desktop application designed for managing and tracking personal finances. Built with Visual Basic .NET and a MySQL database backend, this application provides users with a comprehensive suite of tools to oversee their income, expenses, loans, debts, transactions, budgeting, and financial goals.

---

## 🚀 Features

* **User Authentication:** Secure user login system that tracks user details and session counts.
* **Comprehensive Account Overview:** A central dashboard that queries the database via the user's `AccountID` to display:
    * Total income and total expenses.
    * Latest transaction details.
    * Nearest loan and debt deadlines.
* **Transaction Management:** Dedicated forms to easily add and track daily financial transactions.
* **Financial Planning:** Specialized modules for setting up budgets and tracking long-term financial goals.
* **Debt & Loan Tracking:** Monitor outstanding loans and debts with deadline alerts.
* **Robust Error Handling:** Built-in try-catch blocks that display clear message boxes for database or system errors to ensure a smooth user experience.

---

## 🛠️ Technology Stack

* **Language:** Visual Basic .NET
* **User Interface:** Windows Forms (incorporating `DataGridView` for tabular data, along with `TextBoxes` and `Labels` for summaries)
* **Database:** MySQL
* **Database Connectivity:** ADO.NET utilizing `MySql.Data.MySqlClient`

---

## 📁 Project Structure

The repository contains multiple `.vb` files representing different forms and modules of the application:

* **`Acc.vb` (Main Module):** Handles the global application state. It stores the database connection string template and active user details (Username, Id, Balance, login count).
* **`Account Overview.vb` (Dashboard):** The primary form class providing the financial overview. It retrieves financial data and contains event handlers for smooth navigation to other application sections (Transactions, Loans, Budgeting, Financial Goals, and Login).
* **Additional Forms:** Dedicated UI files for specific tasks such as *Add Transaction*, *Budgeting*, and more.

---

## ⚙️ Getting Started

### Prerequisites
* Visual Studio (with the .NET desktop development workload installed)
* MySQL Server installed and running
* MySQL Connector/NET (`MySql.Data.MySqlClient`)

### Setup Instructions
1. Clone this repository to your local machine.
2. Open the project solution in Visual Studio.
3. Configure your local MySQL database. 
4. Locate the `Acc.vb` module and update the connection string template with your local MySQL server credentials (hostname, database name, username, and password).
5. Build the solution to restore dependencies.
6. Run the application to launch the login form.
