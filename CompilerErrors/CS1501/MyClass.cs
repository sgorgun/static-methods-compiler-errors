namespace CompilerErrors.CS1501
{
    public static class MyClass
    {
        public static int MyMethod()
        {
            return ReturnInt(1_785_394);
        }

        public static int ReturnInt()
        {
            return 1_785_394;
        }
    }
}
