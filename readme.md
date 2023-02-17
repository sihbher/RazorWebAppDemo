# Razor Web App Demo

This example is a simple CRUD application that allows users to create, read, update, and delete records in the Orders table of a SQL Server database. The application uses Razor Pages to provide a user interface for managing the orders data.

The application's homepage displays a list of all orders in the database, along with links to view, edit, or delete each order. Users can also create new orders by clicking the "Create New" button on the homepage.

The details page displays the details of a single order, including its ID, plant ID, amount, price, dispatched status, and timestamps. From this page, users can edit or delete the order using the provided links.

The edit page allows users to modify the details of an existing order. The form includes input fields for the order's plant ID, amount, price, and dispatched status. When the user submits the form, the application updates the corresponding record in the database.

The create page allows users to add a new order to the database. The form includes input fields for the order's plant ID, amount, price, and dispatched status. When the user submits the form, the application creates a new record in the database.

The delete page allows users to delete an existing order from the database. When the user confirms the deletion, the application removes the corresponding record from the database.

Overall, this example demonstrates how to create a simple CRUD application using Razor Pages in a .NET Core web app, with support for SQL Server as the database backend. The application provides an easy-to-use user interface for managing orders data, with support for viewing, editing, creating, and deleting records.