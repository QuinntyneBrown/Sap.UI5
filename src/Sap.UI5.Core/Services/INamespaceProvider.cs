
namespace Sap.UI5.Core
{
    public interface INamespaceProvider
    {
        string Get(string directory, int depth = 0);
    }
}
