# inventory-tracker-demo
Basic CRUD app built with C#, EntityFramework, and Unity.

### Getting Started

1. Open .sln in Visual Studio, restore nuget packages, build solution
2. Update connection string in web.config to point to your local SQL instance
3. From the package manager console, switch to the AuctioneerDemo.Data project and run `update-database`
4. Run the AuctioneerDemo.Web project - there should be some test inventory data to start with


### TODO

1. Add input validation;
2. Basic Identity login works, but is not associated with equipment records yet;
3. Ideally, the web proj wouldn't reference the data proj. Because of how the ApplicationUser class is set up, I'm not entirely sure how to get around this just yet. With more time, will investigate;
4. Tests are obviously lacking, but I at least wanted to get the test suite created with some basic tests stubbed out. This needs to be set up better though, with an actual mock repo so I can test adds/deletes in a more valuable way.