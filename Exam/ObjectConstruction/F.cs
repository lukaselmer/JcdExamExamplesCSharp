namespace Exam.ObjectConstruction
{
    class F : E
    {
        AInternal a3 = new AInternal("a31");
        AInternal a4 = new AInternal("a41");

        public F()
            : this(5)
        {

        }

        private F(int i)
        {
            a4 = new AInternal("a42");
        }
    }
}