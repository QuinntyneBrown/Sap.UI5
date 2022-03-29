namespace Sap.UI5.Core
{
    public interface INamingConventionConverter
    {
        string Convert(NamingConvention from, NamingConvention to, string value);

        string Convert(NamingConvention to, string value);

        string Convert(NamingConvention to, string value, bool pluralize);
    }
}
