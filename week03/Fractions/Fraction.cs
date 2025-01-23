using System;
using System.Data;

public class Frantion
{
    private int _top;
    private int _buttom;

public Frantion()
{
    _top = 1;
    _buttom = 1;
}
public Frantion(int WholeNumber)
{
    _top = WholeNumber;
    _buttom = 1;
}
public Frantion(int top, int button)
{
    _top = top;
    _buttom = button;

}

public int GetTop()
{
    return _top;
}
public void SetTop(int settop)
{
    _top = settop;
}

public int GetButtom()
{
    return _buttom;
}

public void SetButtom(int setbuttom)
{
    _buttom = setbuttom;
}

public string GetFractionString()
{
    string text = $"{_top}/ {_buttom}";
    return text;

}

public double GetDecimalValue()
{
    return (double)_top / (double)_buttom;
}

}

