using Calculator.Lib.Visitors;

namespace Calculator.Lib;

public class Calculator
{
	public double A { get; set; }
	public double B { get; set; }
	public Calculator(double a = 0, double b = 0) {
		A = a;
		B = b;
	}

	public void accept(IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
