using System;

class Encapsulated
{
    private double valueDouble;
    private string valueString;


    public double ValueDouble
    {
        get { return valueDouble; }
        set
        {
            valueDouble = value;
            valueString = value.ToString();
        }
    }

    public string ValueString
    {
        get { return valueString; }
        set {
            
            valueString = value.ToString();
        }
    }
}