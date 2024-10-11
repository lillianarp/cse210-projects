
public class Fraction 
{
    // attributes

    private int _top;
    private int _bottom;

    // behaviours

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters 

    // Return fraction as string 
    public string GetFractionString() 
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }

}