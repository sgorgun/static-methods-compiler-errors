namespace CompilerErrors.CS0117
{
    public static class MyClass
    {
        public static long MyMethod()
        {
            return AnotherClass.Return1ong(longParameter: 49_023_471L);
        }
    }

    public static class AnotherClass
    {
        public static long ReturnLong(long longParameter)
        {
            return longParameter;
        }
    }
}
