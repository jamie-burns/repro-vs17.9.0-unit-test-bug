This solution contains 2 unit test projects, with a single test in each.  Each test attempts to read a connection string from the project's appsettings.json file.  One project (Logic2.Tests) calls the other project (Logic.Tests).

When running these tests in Visual Studio 2022 v17.9.0 the tests occasionally fail.  When running both tests from the Test Explorer, UnitTest1.TestMethod1 always passes, but UnitTest2.TestMethod1 alternatively passes and fails.

Running the exact same solution in Visual Studio 2022 v17.8.2, the tests always pass every time.  Also note that running the tests via `dotnet test` always pass.

When debugging the failing test, the appsettings.json file used is the one from Logic.Tests:

![image](https://github.com/jamie-burns/repro-vs17.9.0-unit-test-bug/assets/12560744/3faa8b3d-3c90-4445-ab8f-d0ac15e817cb)

When re-running the test, the appsettings.json file is from Logic2.Tests instead:

![image](https://github.com/jamie-burns/repro-vs17.9.0-unit-test-bug/assets/12560744/571a4274-68a5-41e8-84a1-982c94838ff8)
