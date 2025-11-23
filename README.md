<h2>Project Setup</h2>
<h3>Requirements</h3>

Install .NET Desktop Runtime (the project uses Windows Forms).
Execute the code included in the TestProject.sql

<h3>Configuration</h3>

Place a file named config next to the application .exe.

The file must contain one line:
your SQL connection string.

<h3>Database Access</h3>

A dedicated DB helper class handles all SQL connections, queries, and parameterized commands.

This keeps interaction with the database clean and centralized.

<h3>Architecture</h3>

Business logic is separated from UI logic.

This improves maintainability and makes redesign or UI updates easier in the future.
