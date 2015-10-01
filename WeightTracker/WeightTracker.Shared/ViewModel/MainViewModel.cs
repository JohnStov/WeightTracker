using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using WeightTracker.AppModel;

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


            series = new LineSeries {MarkerType = MarkerType.Circle};
            PlotModel = new PlotModel();
            PlotModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, MajorStep = 1.0 });
            PlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            PlotModel.Series.Add(series);

            Person = new Person();

            Weigh = new RelayCommand(() =>
            {
            });
        }

        private readonly LineSeries series;

        public Person Person
        {
            set
            {
                foreach (var dataPoint in value.WeightHistory)
                    series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dataPoint.Key), dataPoint.Value));
            }            
        }

        public ICommand Weigh { get; private set; }
        
        public PlotModel PlotModel { get; private set; }
    }
}