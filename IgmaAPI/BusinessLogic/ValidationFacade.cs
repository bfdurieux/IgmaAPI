namespace IgmaAPI.BusinessLogic;

public class CFPValidator
{
  public bool ValidateCPF(string registration)
  {
    if (registration.Distinct().Count() == 1)
      return false;

    var numbersOnly = new string(registration.Where(char.IsDigit).ToArray());
    if (numbersOnly.Length != 11 || numbersOnly.All(number => number == '0'))
      return false;

    var multiplier1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    var multiplier2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

    int remainder;

    var baseNumbers = numbersOnly[..^2];
    var sum = multiplier1.Select((multiplierNumber, i) => multiplierNumber * int.Parse(baseNumbers[i].ToString()))
      .Sum();
    var digits = Math.Abs(GetRemainder(sum)).ToString();

    baseNumbers += digits;
    sum = multiplier2.Select((multiplierNumber, i) => multiplierNumber * int.Parse(baseNumbers[i].ToString())).Sum();
    digits += Math.Abs(GetRemainder(sum));

    return registration.EndsWith(digits);

    int GetRemainder(int sumReference)
    {
      remainder = sumReference % 11;

      if (remainder < 2)
        remainder = 0;
      else
        remainder -= 11;
      return remainder;
    }
  }
}