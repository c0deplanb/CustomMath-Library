namespace Common
{
    public static class CustomMath
    {
        public static float LimitFloat(float min, float value, float max)
        {
            if (value < min) { value = min; return value;}
            if (value > max) { value = max; return value;}
            return value;
        }
        public static int LimitInt(int min, int value, int max)
        {
            if (value < min) { value = min; return value; }
            if (value > max) { value = max; return value; }
            return value;
        }
        public static int AddInt(params int[] numbers)
        {
            int result = 0;
            foreach (int intnumber in numbers) { result += intnumber;}
            return result;
        }
        public static float AddFloat(params float[] numbers) 
        {
            float result = 0f;
            foreach (float floatnum in numbers) {result += floatnum;}
            return result;

        }
        public static int SubInt(params int[] numbers)
        { 
            int result = numbers[0];
            foreach (int intnumber in numbers) { result -= intnumber;}
            return result;
        }
        public static float SubFloat(params float[] numbers)
        {
            float result = numbers[0];
            foreach(float floatnum in numbers) { result -= floatnum;}
            return result;
        }
        public static int MultiInt(params int[] numbers)
        {
            int result = 1;
            foreach (int intnumber in numbers) { result *= intnumber;}
            return result;
        }
        public static float MultiFloat(params float[] rudiismyidol)
        {
            float result = 1;
            foreach(float number in rudiismyidol) {result *= number;}
            return result;
        }
        public static int PowerInt(int value, int uppernumber)
        {
            int result = 1;

            for (int i = 0; i < uppernumber; i++)
            {
                result *= value;
            }
            return result;
        }
        public static float PowerFloat(float value, float uppernumber)
        {
            float result = 1f;

            for (int i = 0; i < uppernumber; i++)
            {
                result *= value;
            }
            return result;
        }

        public static float SquareRoot(float value)
        {
            float result = 1f;

            if (value < 0f)
            {
                return 0f;
            }
            result = PowerFloat(value, 0.5f);
            return result;
        }

        public static float Average(params float[] numbers)
        {
            if (numbers.Length == 0) return 0f;

            float total = AddFloat(numbers);

            return total / numbers.Length;

        }
    }
}