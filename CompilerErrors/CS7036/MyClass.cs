namespace CompilerErrors.CS7036
{
    public static class MyClass
    {
        public static int MyMethod()
        {
            return ReturnInt();
        }

        public static int ReturnInt(int intParameter)
        {
            return intParameter;
        }
    }
}
