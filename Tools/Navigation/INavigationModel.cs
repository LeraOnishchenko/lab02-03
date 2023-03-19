namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools.Navigation
{
    internal enum ViewType
    {
        Input,
        Processed
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
