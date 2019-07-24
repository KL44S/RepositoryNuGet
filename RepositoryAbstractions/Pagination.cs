namespace RepositoryAccess
{
    public class Pagination
    {
        public int SkipNumber { get; set; }
        public int TakeNumber { get; set; }

        public Pagination(int skipNumber, int takeNumber)
        {
            this.SkipNumber = skipNumber;
            this.TakeNumber = takeNumber;
        }
    }
}
