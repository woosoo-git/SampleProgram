using System;
using System.Collections.Generic;
using System.Text;
using LiveCharts;
using LiveCharts.Wpf;
using SampleProgram.Class;

namespace SampleProgram.Controls.ViewModel
{
    public class LiveChartControlViewModel : PropertyChangeBase
    {
        private string[] _subjectName = new[] { "국어", "영어", "수학", "과학", "사회" };
        public string[] SubjectName
        {
            get { return _subjectName; }
            set
            {
                _subjectName = value;
                onPropertyChanged();
            }
        }

        private ChartValues<int> _myScore = new ChartValues<int>();
        public ChartValues<int> MyScore
        {
            get => _myScore;
            set
            {
                _myScore = value;
                onPropertyChanged();
            }
        }

        private ChartValues<int> _avgScore = new ChartValues<int>();
        public ChartValues<int> AvgScore
        {
            get => _avgScore;
            set
            {
                _avgScore = value;
                onPropertyChanged();
            }
        }

        private ChartValues<int> _subjectScore = new ChartValues<int>();
        public ChartValues<int> SubjectScore
        {
            get => _subjectScore;
            set
            {
                _subjectScore = value;
                onPropertyChanged();
            }
        }

        private SeriesCollection _studyTimes = new SeriesCollection();
        public SeriesCollection StudyTimes
        {
            get => _studyTimes;
            set
            {
                _studyTimes = value;
                onPropertyChanged();
            }
        }

        public LiveChartControlViewModel()
        {
            MyScore.Add(91);
            MyScore.Add(86);
            MyScore.Add(86);
            MyScore.Add(94);
            MyScore.Add(77);
            MyScore.Add(97);
            MyScore.Add(78);
            MyScore.Add(84);
            MyScore.Add(77);
            MyScore.Add(98);
            MyScore.Add(78);
            MyScore.Add(84);

            AvgScore.Add(79);
            AvgScore.Add(80);
            AvgScore.Add(80);
            AvgScore.Add(81);
            AvgScore.Add(81);
            AvgScore.Add(85);
            AvgScore.Add(78);
            AvgScore.Add(78);
            AvgScore.Add(80);
            AvgScore.Add(83);
            AvgScore.Add(77);
            AvgScore.Add(80);

            StudyTimes.Add(new PieSeries() {Title = "국어", Values = new ChartValues<int> { 34 }, DataLabels = true});
            StudyTimes.Add(new PieSeries() { Title = "영어", Values = new ChartValues<int> { 43 }, DataLabels = true });
            StudyTimes.Add(new PieSeries() { Title = "수학", Values = new ChartValues<int> { 54 }, DataLabels = true });
            StudyTimes.Add(new PieSeries() { Title = "과학", Values = new ChartValues<int> { 30 }, DataLabels = true });
            StudyTimes.Add(new PieSeries() { Title = "사회", Values = new ChartValues<int> { 22 }, DataLabels = true });

            SubjectScore.Add(80);
            SubjectScore.Add(70);
            SubjectScore.Add(81);
            SubjectScore.Add(90);
            SubjectScore.Add(86);
        }

    }
}
