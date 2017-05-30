# xup2
Migrations for .NET Core 2.0

# intro
**Xup** is designed with raw **SQL** migrations in mind. It's for those moments when you want to take full control of your database and more importantly: the data in it.

**Xup** is heavily inspired by **Flyway** and though it borrows a bit of API design it has been rewritten from the ground up on **.NET Core 2.0** (although we intend to target **.NET Standard 1.3** or lower).

It tries to avoid re-inventing the wheel while staying as lean as possible. It focusses on **SQL Server** for now although it shouldn't be hard to implement any addititional `System.Data` compliant drivers in the future.

# config
* sqlMigrationPrefix (default `V`)
* repeatableSqlMigrationPrefix (default `R`)
* sqlMigrationSeparator (default `__`)
* sqlMigrationSuffix (default `.sql`)
