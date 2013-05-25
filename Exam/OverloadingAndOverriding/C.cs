namespace Exam.OverloadingAndOverriding
{
    class C : B, I
    {

        public new int P
        {
            get { return 2; }
        }
    }
}