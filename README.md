# azure-pipelines-examples


## Know issues

### SonarQube Prepare fails with error: It was not possible to find any compatible framework version.

You might get the following error if .NET Core SDK 2.x is not available on the server.

```
##[error]It was not possible to find any compatible framework version
The framework 'Microsoft.NETCore.App', version '2.0.0' was not found.
It was not possible to find any compatible framework version
```

The SonarQube scanner is build against .NET Core 2.1: https://github.com/SonarSource/sonar-scanner-msbuild/issues/797. You need to install it manually or use the `UseDotNet` task.

### SonarQube Prepare fails with error: To use the property "sonar.branch.name" and analyze branches...

If you're using the Community Edition of SonarQube you might get the following error because you're missing branch support.

```
ERROR: Validation of project failed:
  o To use the property "sonar.branch.name" and analyze branches, Developer Edition or above is required. See https://redirect.sonarsource.com/doc/branches.html for more information.
ERROR:
ERROR: Error during SonarScanner execution
ERROR: Validation of project failed:
  o To use the property "sonar.branch.name" and analyze branches, Developer Edition or above is required. See https://redirect.sonarsource.com/doc/branches.html for more information.
ERROR: 
```

If your default branch differs from master you might have to rename it or upgrade the SonarQube edition.