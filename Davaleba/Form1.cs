namespace Davaleba;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
        double.TryParse(txtA.Text, out double a);
        double.TryParse(txtB.Text, out double b);
        double.TryParse(txtC.Text, out double c);

        // 2.1.19  (a = გვერდი, b = კუთხე გრადუსებში)
        double S = a * a * Math.Sin(b * Math.PI / 180);
        txtResult.Text = "S = " + S;

        // 2.1.20  (a = გვერდი)
        // double d = a * Math.Sqrt(2); 
        // txtResult.Text = "d = " + d;

        // 2.1.21  (a, b = გვერდები, c = კუთხე გრადუსებში)
        // double S = a * b * Math.Sin(c * Math.PI / 180);
        // txtResult.Text = "S = " + S;

        // 2.1.22  (a = A რიცხვი, b = P პროცენტი)
        // double B = a * b / 100;
        // txtResult.Text = "B = " + B;

        // 2.1.23  (a = B რიცხვი, b = P პროცენტი)
        // double A = a * 100 / b;
        // txtResult.Text = "A = " + A;

        // 2.1.24  (a = ფუტი)
        // double sm = a * 30.48;
        // txtResult.Text = a + " ფუტი = " + sm + " სმ";

        // 2.1.25  (a = ფუნტი)
        // double g = a * 409.5;
        // txtResult.Text = a + " ფუნტი = " + g + " გრამი";

        // 2.1.26  (a = დიუმი)
        // double sm = a * 2.54;
        // txtResult.Text = a + " დიუმი = " + sm + " სმ";

        // 2.1.27  (a = იარდი)
        // double m = a * 0.9144;
        // txtResult.Text = a + " იარდი = " + m + " მ";

        // 2.1.28  (a = არშინი)
        // double m = a * 0.711;
        // txtResult.Text = a + " არშინი = " + m + " მ";

        // 2.1.29  (a = საჟენი)
        // double m = a * 2.1336;
        // txtResult.Text = a + " საჟენი = " + m + " მ";

        // 2.1.30  (a, b, c = გვერდები)
        // if (a + b > c && a + c > b && b + c > a)
        //     txtResult.Text = "სამკუთხედი არსებობს";
        // else
        //     txtResult.Text = "სამკუთხედი არ არსებობს";

        // 2.1.31  (a, b = კათეტები, c = ჰიპოტენუზა)
        // if (a * a + b * b == c * c)
        //     txtResult.Text = "მართკუთხა სამკუთხედია";
        // else
        //     txtResult.Text = "არ არის მართკუთხა სამკუთხედი";
    }
}
