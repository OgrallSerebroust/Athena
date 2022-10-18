using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System;
using NSubstitute;
using NSubstitute.Routing.Handlers;

namespace AthenaNewGeneration;

public class ViewModel
{
    readonly ContextModelDonatePrice _databaseDonatePrice = new();
    public ObservableCollection<DonatePrice> DonatesPrices { get; set; }
    
    public ViewModel()
    {
        _databaseDonatePrice.DonatesPrises.Load();
        DonatesPrices = _databaseDonatePrice.DonatesPrises.Local.ToObservableCollection();
        _clickCommand = new DelegateCommand(Click);
    }

    private string _ourDonate;

    public string OurDonate
    {
        get { return _ourDonate; }
        set
        {
            if (_ourDonate != value)
            {
                _ourDonate = value;
            }
        }
    }

    private void Click()
    {
        Random randomizer = new();
        var ourDonate = (short)randomizer.Next(1, 500);
        OurDonate = ourDonate.ToString();
        //OurDonatShowing.Text = ourDonate.ToString();
    }

    private ICommand _clickCommand;

    public ICommand ClickCommand
    {
        get { return _clickCommand; }
        private set {}
    }
}