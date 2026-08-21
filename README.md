# Event & Ticket Management

Events, ticket inventory, attendees and check-in-ready workflow. This repository is a runnable ASP.NET Core MVC 8.0 + EF Core SQLite foundation intended for extension into a full management product.

## Working features

- MVC dashboard landing page with a domain-specific navigation entry.
- EF Core 8 DbContext and SQLite database created automatically on first run.
- Seed record for immediate verification.
- Search and status filtering.
- Create, edit, delete and server-side validation.
- Responsive custom styling with clear operational states.

## Requirements

- .NET SDK 8.0 or later.

## Run

```bash
dotnet restore
dotnet run
```

Open the URL printed by the CLI and select **Manage records**. The database file is generated in the project directory.

## Production roadmap

Add ASP.NET Core Identity and role policies, replace EnsureCreated with EF Core migrations, add the remaining domain relationships, audit logging, file storage, reporting, automated tests, and SQL Server deployment configuration.

## License

MIT
