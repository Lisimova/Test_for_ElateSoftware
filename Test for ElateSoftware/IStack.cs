

namespace Test_for_ElateSoftware
{
    interface IStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsEmpty();
    }
}
