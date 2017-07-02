namespace SolutionsTests
{
    public abstract class TestBase<T> where T: new()
    {
        protected TestBase()
        {
            Solution = new T();
        }

        protected T Solution { get; private set; }
    }
}