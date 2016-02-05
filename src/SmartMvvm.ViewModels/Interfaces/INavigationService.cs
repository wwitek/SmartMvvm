namespace SmartMvvm.ViewModels.Interfaces
{
    public interface INavigationService
    {
        void GoForward();
        void GoBack();
        bool Navigate(string page);
    }
}
