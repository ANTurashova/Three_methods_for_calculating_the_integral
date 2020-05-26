using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Integrating {
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
            drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0); //LowerBoundRectVal = Ниж инт //UpperBoundRectVal = Верх инт 
        }

        //Появляющийся в начале график функции 
        public void drawGraphic(double left, double right, int part)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            double x = left;
            while (x <= right)
            {
                double y = Formula(x);
                chart1.Series[0].Points.AddXY(x, y);
                x = x + 0.1;
            }
        }

        //Кнопка "Посчитать", запуск с учётом значения из ComboBox 
        async public void button1_Click(object sender, EventArgs e)  //кнопка пуска
        {
            chart1.Series[0].Points.Clear();
            if (chart1.Series.FindByName("Hists") != null)
                chart1.Series["Hists"].Points.Clear();
            if (chart1.Series.FindByName("Points") != null)
                chart1.Series["Points"].Points.Clear();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                if (chart1.Series.FindByName("Thread №" + i.ToString()) != null)
                {
                    chart1.Series["Thread №" + i.ToString()].Points.Clear();
                }
            }
            Calculation iProcessor = new Calculation(Formula); //иниц Calculation
            switch (comboBox1.Text)
            {
                case "Прямоугольники":
                    {
                        if (chart1.Series.FindByName("Hists") == null)
                        {
                            chart1.Series.Add("Hists");
                            chart1.Series["Hists"]["PointWidth"] = "1";
                        }
                        drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0); //LowerBoundRectVal = Ниж инт //UpperBoundRectVal = Верх инт
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventFinish += OnFinishTime;
                        iProcessor.EventDraw += DrawHist;
                        iProcessor.EventFinish += OnFinish;
                        //ОБРАЩЕНИЕ К МЕТОДУ ПРЯМОУГОЛЬНИКОВ
                        await Task.Run(() => iProcessor.Rectangular(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), Decimal.ToInt32(NumStratsMonteVal.Value))); //LowerBoundRectVal = Ниж инт //UpperBoundRectVal = Верх инт //NumStratsMonteVal = Разбиение поля для точек
                        progressBar1.Value = 0; //progressBar1 = полоска загрузки 
                        break;
                    }
                case "Метод Монте-Карло":
                    {
                        if (chart1.Series.FindByName("Points") == null)
                        {
                            chart1.Series.Add("Points");
                            chart1.Series.FindByName("Points").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                            chart1.Series.FindByName("Points").MarkerSize = 2;
                        }
                        drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0); //LowerBoundMonteVal = нижняя граница инт //UpperBoundMonteVal = верхняя граница инт //Decimal.ToDouble () для преобразования значения указанного десятичного числа в эквивалентное число с плавающей запятой двойной точности
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventFinish += OnFinish;
                        iProcessor.EventFinish += OnFinishTime;
                        iProcessor.EventDraw += DrawPoint;
                        //ОБРАЩЕНИЕ К МЕТОДУ МОНТЕ-КАРЛО
                        await Task.Run(() => iProcessor.Monte_Carlo(
                            Decimal.ToDouble(LowerBoundRectVal.Value), //LowerBoundMonteVal = Нижняя граница инт 
                            Decimal.ToDouble(UpperBoundRectVal.Value), //UpperBoundMonteVal = Верхняя граница инт 
                            Decimal.ToInt32(ThrowsMultMonteVal.Value), //InfimumMonteVal = Ниж гран точек
                            Decimal.ToDouble(SupremumMonteVal.Value), //SupremumMonteVal = Верх гран точек
                            Decimal.ToDouble(InfimumMonteVal.Value), //InfimumMonteVal = Частота точек
                            Decimal.ToInt32(NumStratsMonteVal.Value))); //NumStratsMonteVal = Разбиение поля для точек
                        progressBar1.Value = 0; //progressBar1 = полоска загрузки
                        break;
                    }
                case "Метод Симпсона":
                    {
                        for (int i = 0; i < Environment.ProcessorCount; i++)
                        {
                            if (chart1.Series.FindByName("Thread №" + i.ToString()) == null)
                            {
                                chart1.Series.Add("Thread №" + i.ToString());
                                chart1.Series["Thread №" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                            }
                        }
                        drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0); //LowerBoundRectVal = Ниж инт //UpperBoundRectVal = Верх инт
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventFinish += OnFinish;
                        iProcessor.EventFinish += OnFinishTime;
                        iProcessor.EventDraw += drawParabola;
                        //ОБРАЩЕНИЕ К МЕТОДУ СИМПСОНА
                        await Task.Run(() => iProcessor.Simpson(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), Decimal.ToInt32(NumStratsMonteVal.Value))); //LowerBoundRectVal = Ниж инт //UpperBoundRectVal = Верх инт //NumStratsMonteVal = Разбиение поля для точек
                        progressBar1.Value = 0; //progressBar1 = полоска загрузки
                        break;
                    }
            }
        }

        //Прямоугольники из метода средних прямоугольнтков
        public void DrawHist(double x, double y, int part)
        {
            if (!chart1.InvokeRequired)
            {
                chart1.Series.FindByName("Hists").Points.AddXY(x, Formula(x));

            }
            else
            {
                object[] pars = { x, y, part };
                Invoke(new Calculation.ToDraw(DrawHist), pars); //иниц Calculation
            }
        }

        //Параболы для метода Симпсона 
        public void drawParabola(double left, double right, int part) 
        {
            double dx = (right - left)/( Decimal.ToInt32(NumStratsMonteVal.Value) * 4); //NumStratsMonteVal = Разбиение поля для точек
            double middle = (right - left) / 2;
            double interpol(double _x) 
            {
                return Formula(left) * (_x - middle) * (_x - right) / ((left - middle) * (left - right)) + Formula(middle) * (_x - left) * (_x - right) / ((middle - left) * (middle - right)) + Formula(right) * (_x - left) * (_x - middle) / ((right - left) * (right - middle));
            }
            if (!chart1.InvokeRequired) 
            {
                double x = left-dx*75;
                while (x <= right+dx*75) 
                {
                    chart1.Series["Thread №" + part.ToString()].Points.AddXY(x, interpol(x));
                    x = x + dx;
                }
            } 
            else 
            {
                object[] pars = {left, right, part }; //размер мини-парабол для метода симпсона
                Invoke(new Calculation.ToDraw(drawParabola), pars); //иниц Calculation
            }
        }

        //Точки метода Монте-Карло
        public void DrawPoint(double x, double y, int part)
        {
            if (!chart1.InvokeRequired)
            {
                chart1.Series.FindByName("Points").Points.AddXY(x, y);
            }
            else
            {
                object[] pars = { x, y, part };
                Invoke(new Calculation.ToDraw(DrawPoint), pars); //иниц Calculation
            }
        }

        //Полоса загрузки 
        public void OnProgress(int value) 
        { //клик от полоса загрузки
            if (!progressBar1.InvokeRequired) //progressBar1 = полоска загрузки
            { 
                if (value <= 100 ) progressBar1.Value = value; //progressBar1 = полоска загрузки
            } 
            else Invoke(new Calculation.Progress(OnProgress), value); //иниц Calculation
        }

        //Для вывода времени подсчёта
        public void OnFinishTime(double resVal, long time) 
        {
            if (!label14.InvokeRequired)  //label14 = время работы
            {
                label14.Text = (time/1000.0).ToString() + " сек."; //текст времени работы //label14 = время работы
            } else 
            {
                object[] pars = { resVal, time };
                Invoke(new Calculation.Finish(OnFinishTime), pars); //иниц Calculation

            }
        }

        //Для вывода результата подчёта 
        public void OnFinish(double resVal, long time) //чисто для вывода результата
        {
            if (!progressBar1.InvokeRequired) //progressBar1 = полоска загрузки
            {
                textBoxResult.Text = resVal.ToString(); //textBoxResult = % работы и результат
            }
            else
            {
                object[] pars = { resVal, time };
                Invoke(new Calculation.Finish(OnFinish), pars); //иниц Calculation
            }
        }

        //Формула, 9 вариант
        double Formula(double x) { return x * x * x + 10 * x * x; }  
    }
}
