using Calculator.Lib.Visitors;

namespace Calculator.Lib;

public class ThreeNumbers : ICalculator
{
	public double A { get; set; }
	public double B { get; set; }
	public double C { get; set; }
	public ThreeNumbers(double a = 0, double b = 0, double c = 0) {
		A = a;
		B = b;
		C = c;
	}

	public void accept(IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
