using System.Collections.Generic;

namespace Sap.UI5.Core
{
    public interface ITemplateProcessor
    {
        string[] Process(string[] template, IDictionary<string, object> tokens, string[] ignoreTokens = null);
        string Process(string template, IDictionary<string, object> tokens);
    }
}
