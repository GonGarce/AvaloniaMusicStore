using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.MusicStore.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        ShowDialog = new Interaction<MusicStoreViewModel, AlbumViewModel?>();
    }

    [RelayCommand]
    private async Task BuyMusicAsync()
    {
        var store = new MusicStoreViewModel();

        var result = await ShowDialog.HandleAsync(store);
    }
    
    /// <summary>
    /// Gets an instance of our own Interaction class
    /// </summary>
    public Interaction<MusicStoreViewModel, AlbumViewModel?> ShowDialog { get; }
}