dotnet tool uninstall -g Sap.UI5
dotnet pack
dotnet tool install --global --add-source ./nupkg Sap.UI5
