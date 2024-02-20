This solution contains 2 unit test projects, with a single test in each.  Each test attempts to read a connection string from the project's appsettings.json file.  One project (Logic2.Tests) calls the other project (Logic.Tests).

When running these tests in Visual Studio 2022 v17.9.0 the tests occasionally fail.  When running both tests from the Test Explorer, UnitTest1.TestMethod1 always passes, but UnitTest2.TestMethod1 alternatively passes and fails.

Running the exact same solution in Visual Studio 2022 v17.8.2, the tests always pass every time.  Also note that running the tests via `dotnet test` always pass.
