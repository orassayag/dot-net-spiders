# Contributing

Contributions to this project are [released](https://help.github.com/articles/github-terms-of-service/#6-contributions-under-repository-license) to the public under the [project's open source license](LICENSE).

Everyone is welcome to contribute to this project. Contributing doesn't just mean submitting pull requests—there are many different ways for you to get involved, including answering questions, reporting issues, improving documentation, or suggesting new features.

## How to Contribute

### Reporting Issues

If you find a bug or have a feature request:
1. Check if the issue already exists in the [GitHub Issues](https://github.com/orassayag/dot-net-spiders/issues)
2. If not, create a new issue with:
   - Clear title and description
   - Steps to reproduce (for bugs)
   - Expected vs actual behavior
   - Error messages (if applicable)
   - Your environment details (OS, .NET version, SQL Server version)

### Submitting Pull Requests

1. Fork the repository
2. Create a new branch for your feature/fix:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes following the code style guidelines below
4. Test your changes thoroughly with the target websites
5. Commit with clear, descriptive messages
6. Push to your fork and submit a pull request

### Code Style Guidelines

This project uses:
- **C# / ASP.NET Web Forms** (legacy .NET Framework)
- **LINQ to SQL** for database operations
- **SQL Server** stored procedures
- **Regular expressions** for email extraction

Before submitting:
```bash
# Build the solution
msbuild CVSpider.sln

# Test the spider functionality manually
# Run the web application and verify email extraction
```

### Coding Standards

1. **Regex patterns**: Store complex patterns in constants for maintainability
2. **Database operations**: Use parameterized queries to prevent SQL injection
3. **Error handling**: Implement retry logic for network operations
4. **Email validation**: Ensure proper validation and sanitization
5. **Logging**: Add logging for debugging spider behavior
6. **Comments**: Document complex logic, especially regex patterns and web scraping rules

### Adding New Spider Features

When adding new spiders or data sources:
1. Create a new handler (`.ashx`) or page for the spider
2. Implement proper URL construction and parameter handling
3. Add regex patterns for data extraction
4. Implement email validation and deduplication
5. Add database persistence logic
6. Test thoroughly against target websites
7. Document the spider's purpose and target sites

### Database Schema Updates

When modifying the database:
1. Update LINQ to SQL classes (`.dbml` files)
2. Create or update stored procedures
3. Test database operations thoroughly
4. Document schema changes in pull request

### Important Notes

- **Legal compliance**: Ensure all web scraping activities comply with target website terms of service and robots.txt
- **Rate limiting**: Implement delays between requests to avoid overwhelming target servers
- **Data privacy**: Handle collected email addresses responsibly and in compliance with privacy laws
- **Target website changes**: Be aware that HTML structure changes may break scrapers

## Questions or Need Help?

Please feel free to contact me with any question, comment, pull-request, issue, or any other thing you have in mind.

* Or Assayag <orassayag@gmail.com>
* GitHub: https://github.com/orassayag
* StackOverflow: https://stackoverflow.com/users/4442606/or-assayag?tab=profile
* LinkedIn: https://linkedin.com/in/orassayag

Thank you for contributing! 🙏
