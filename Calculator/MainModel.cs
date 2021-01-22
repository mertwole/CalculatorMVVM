namespace Calculator
{
    public class MainModel
    {
        string input = "";
        // Clear all symbols only when there is the result of previous calculation on screen.
        bool clear_all = false;
        bool error = false;

        public string Evaluate()
        {
            return input;
        }

        public void Input(string i)
        {
            if (i == "=")
            {
                string evaluated = "";

                try
                {
                    var parsed = Parser.Parser.Parse(input);
                    evaluated = parsed.ToString();
                }
                catch
                {
                    evaluated = "error!";
                    error = true;
                }

                // Evaluation success.
                input = evaluated;
                clear_all = true;
            }
            else if (i == "clear_symbol")
            {
                if (clear_all)
                    input = "";
                else if (input.Length != 0)
                    input = input.Remove(input.Length - 1);
            }
            else
            {
                if(error)
                {
                    input = "";
                    error = false;
                }

                input += i;
                clear_all = false;
            }
        }
    }
}
