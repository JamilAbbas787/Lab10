namespace Lab10
{
    class Validator
    {
        public static bool Verify(string radius)
        {
            bool converstionToInt =  int.TryParse(radius, out int radiusToNumber);
            if (converstionToInt)
            {
                return true;
            }
            return false;
        }

    }


}


