using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.ComponentModel;

public class NumericUpDownPoundSign : NumericUpDown
{
    public NumericUpDownPoundSign()
    { }

    private string _leadingSign = "";
    public string LeadingSign
    {
        get { return _leadingSign; }
        set { _leadingSign = value; this.UpdateEditText(); }
    }

    protected override void UpdateEditText()
    {
        if (UserEdit)
        {
            ParseEditText();
        }

        ChangingText = true;
        base.Text = _leadingSign + GetNumberText(this.Value);
    }

    private string GetNumberText(decimal num)
    {
        string text;

        if (Hexadecimal)
        {
            text = ((Int64)num).ToString("X", CultureInfo.InvariantCulture);
        }
        else
        {
            text = num.ToString((ThousandsSeparator ? "N" : "F") + DecimalPlaces.ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
        }
        return text;
    }

    protected override void ValidateEditText()
    {
        ParseEditText();
        UpdateEditText();
    }

    protected new void ParseEditText()
    {
        try
        {
            string text = base.Text;
            if (!string.IsNullOrEmpty(_leadingSign))
            {
                if (text.StartsWith(_leadingSign))
                    text = text.Substring(_leadingSign.Length);
            }
            if (!string.IsNullOrEmpty(text) &&
                !(text.Length == 1 && text == "-"))
            {
                if (Hexadecimal)
                {
                    base.Value = Constrain(Convert.ToDecimal(Convert.ToInt32(text, 16)));
                }
                else
                {
                    base.Value = Constrain(decimal.Parse(text, CultureInfo.CurrentCulture));
                }
            }
        }
        catch
        {

        }
        finally
        {
            UserEdit = false;
        }
    }

    private decimal Constrain(decimal value)
    {
        if (value < base.Minimum)
            value = base.Minimum;

        if (value > base.Maximum)
            value = base.Maximum;

        return value;
    }

}
