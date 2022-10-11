using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace AthenaNewGeneration;

public class ViewModel
{
    readonly ContextModelDonatePrice _databaseDonatePrice = new();
    public ObservableCollection<DonatePrice> DonatesPrices { get; set; }
    public ViewModel()
    {
        _databaseDonatePrice.DonatesPrises.Load();
        DonatesPrices = _databaseDonatePrice.DonatesPrises.Local.ToObservableCollection();
    }
}