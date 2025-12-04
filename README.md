# Employee Eats – Cafeteria Credit & Ordering System
### Technical Assessment Submission – Junior ASP.NET Core Developer  
**Candidate:** Jabulani Conjugation Sibeko  
**Date:04 December 2025

## Project Overview
A fully functional employee cafeteria benefit web application built with **ASP.NET Core 8 MVC**, **Entity Framework Core**, and **SQL Server LocalDB**.

This solution **100% fulfills all core requirements** of the technical assessment, including the critical deposit bonus logic, balance validation, order processing, and admin delivery management.

## Core Features Delivered (Exactly as Specified)

| Requirement                                  | Status                                                                   | Implementation                                                 |
|----------------------------------------------|--------------------------------------------------------------------------|----------------------------------------------------------------|
| ASP.NET Core MVC project                     | Completed                                                                | Clean separation of concerns                                   |
| Entity Framework Core + LocalDB              | Completed                                                                | Migrations fully applied                                       |
| Employee model with `LastDepositMonth`       | Completed                                                                | Year-Month tracking implemented                                |
| Restaurant → MenuItem one-to-many relationship | Completed                                                              | Correctly configured in DbContext                              |
| Full CRUD for Restaurants & Menu Items (Admin) |Completed                                                               | Dedicated "Manage Menu" pages                                  |
| Deposit with **exact R250 → R500 bonus logic** | Completed                                                              | Critical logic 100% correct                                    |
| Monthly bonus reset using `LastDepositMonth` | Completed                                                                | Resets on new calendar month                                   |
| Order placement with balance check & deduction | Completed                                                              | Prevents overspending                                          |
| `Order` and `OrderItem` models with `UnitPriceAtTimeOfOrder` | Completed                                                | Price locking implemented                                      |
| Employee order history with status          | Completed                                                                 | Fully working                                                  |
| Admin view to update order status (Pending → Delivered) | Completed                                                     | Dedicated admin page                                           |
| ASP.NET Core Identity – Registration & Login | Completed                                                                | Full authentication                                            |
| Orders automatically linked to logged-in user | Completed                                                               | No manual EmployeeNumber entry                                 |
| Yoco payment simulation (test card)         | Completed                                                                 | 4242 4242 4242 4242 mm/yyyy  Can be anything and the security  |

## Bonus / Stretch Features Included
- Clean, responsive UI with Bootstrap
- Shopping cart experience
- Order confirmation page
- Detailed order status tracking
- Proper price preservation in order history

## How to Run (5 Minutes Setup)

```bash
git clone https://github.com/JabulaniSibeko11/EMPLOYEE_EATS_APP.git
cd EMPLOYEE_EATS_APP
dotnet restore
dotnet ef database update
dotnet run
