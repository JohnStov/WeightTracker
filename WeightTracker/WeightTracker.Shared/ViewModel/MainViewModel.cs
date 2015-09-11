using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using OxyPlot;
using OxyPlot.Axes;
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


            var series = new LineSeries {MarkerType = MarkerType.Circle};
            PlotModel = new PlotModel();
            PlotModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, MajorStep = 1.0 });
            PlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            PlotModel.Series.Add(series);

            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 4)), 96.4));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 5)), 96.2));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 7)), 95.8));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 8)), 95.8));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 9)), 96.0));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 10)), 96.6));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 9, 11)), 97.0));
        }

        public PlotModel PlotModel { get; private set; }
    }
}