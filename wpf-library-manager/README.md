# WPF Library / Customer Management (C# + SQL Server)

A Spanish-language classroom desktop application with screens to list, insert, update, and delete **customer** records and inspect or delete related **orders**. Despite the original folder name `GestionLibreria` (Library Management), the implemented UI currently focuses on customers and orders rather than a complete catalog or circulation system.

## Demonstrates

C#, WPF, XAML, `SqlConnection`, `SqlDataAdapter`, parameterized SQL commands and CRUD fundamentals.

## Requirements

- **Windows**, Visual Studio with .NET Framework desktop development
- **.NET Framework 4.7.2** and SQL Server LocalDB (or a configured SQL Server instance)

## Getting started

1. Run `schema.sql` on your local SQL Server instance. It creates a demonstration database with fictional records.
2. Confirm the `GestionLibreriaConnectionString` in `GestionLibreria/App.config` points to your SQL Server. It uses Windows integrated authentication.
3. Open `GestionLibreria.sln`, restore any needed dependencies, and build on Windows.
4. Start the app, select a customer, and test listing/updating/orders against the demonstration database. Do not use production or real customer data.

## Known limitations

- This is an older classroom UI, not a production database client.
- Error handling, selected-row validation, and transaction management remain limited.
- Updating a record and deletion of related records require care; records are for local testing only.
- A successful GUI build/test has **not** been verified in this environment.

## Fixes made while preparing the portfolio

Corrected `CLEINTE` to `CLIENTE` and parameterized the customer ID in the update statement; changed old machine-specific SQL server name to `(localdb)\MSSQLLocalDB`; removed a hard-coded personal desktop image path. These maintenance changes were made with AI assistance.
