namespace Sap.UI5.Core
{
    public interface ITenseConverter
    {
        string Convert(string value, bool pastTense = true);
    }
}
