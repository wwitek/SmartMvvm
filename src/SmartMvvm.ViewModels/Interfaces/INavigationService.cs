namespace SmartMvvm.ViewModels.Interfaces
{
    public interface INavigationService
    {
        void InjectPage(string pageKey, IPageViewModel viewModel);
        void GoForward();
        void GoBack();
        bool Navigate(string pageKey);
        bool Navigate(IPageViewModel pageViewModel);
    }
}
