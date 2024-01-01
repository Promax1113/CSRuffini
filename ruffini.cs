namespace ruffini
{
    public class Ruffini
    {
        public static (List<int> result, int remainder) CalcRuffini(int multip, List<int> coefficients)
        {
            List<int> results = [coefficients[0]];

            coefficients.RemoveAt(0);

            for (int i = 0; i < coefficients.Count; i++)
            {
                results.Add((results[i] * multip) + coefficients[i]);
            }

            int remainder = results.ElementAt(results.Count - 1);
            results.RemoveAt(results.Count - 1);

            return (results, remainder);
        }
    }

    public class Ruffini_tests
    {

        public static bool TestRuffini(List<int> _coef, int _multip, List<int> _solution, int _remainder)
        {

            (List<int> result, int remainder) = Ruffini.CalcRuffini(_multip, _coef);

            if (remainder == _remainder)
            {
                if (result[^1] == _solution[^1])
                {
                    return true;
                }
            }

            return false;

        }
    }

}
