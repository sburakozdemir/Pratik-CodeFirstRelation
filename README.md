# Patika CodeFirst Relation Project

## Overview

This project demonstrates how to create and manage relationships between tables using the **Code First** approach in **Entity Framework Core**. We define two tables, `Users` and `Posts`, where each user can have multiple posts, but each post belongs to a single user.

### Tables:

- **User Table**:
  - `Id`: Integer, primary key, and auto-increment.
  - `Username`: String, represents the username of the user.
  - `Email`: String, represents the user's email address.

- **Post Table**:
  - `Id`: Integer, primary key, and auto-increment.
  - `Title`: String, represents the post's title.
  - `Content`: String, represents the content of the post.
  - `UserId`: Integer, foreign key linking the post to a user.

### Database Context

The context class used to manage the database is `PatikaSecondDbContext`. It handles the `Users` and `Posts` tables with a relationship established between them.

---

## Project Structure

- **Entities**:
  - `UserEntity`: Represents the User table in the database.
  - `PostEntity`: Represents the Post table in the database.

- **DbContext**:
  - `PatikaSecondDbContext`: The database context that manages the tables and relationships.

---

## Database Connection

The database connection is defined in the `appsettings.json` file. Make sure to update the connection string to match your environment if necessary.

```json
{
  "ConnectionStrings": {
    "default": "server=DESKTOP-B5AKKUH\\SQLEXPRESS; database=PatikaCodeFirstDb2; TrustServerCertificate=true; trusted_connection = true;"
  }
}
```

---
