using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using OxyPlot;
using OxyPlot.Series;

namespace WeightTracker.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}


            var series = new LineSeries();
            PlotModel = new PlotModel();
            PlotModel.Series.Add(series);

            series.Points.Add(new DataPoint(1.0, 1.0));
            series.Points.Add(new DataPoint(2.0, 1.5));
            series.Points.Add(new DataPoint(3.0, 1.75));
        }

        public PlotModel PlotModel { get; private set; }
    }
}