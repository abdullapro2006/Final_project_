namespace finalProject.Services.Concrete
{
    internal class ConsoleTable
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public ConsoleTable(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void AddRow(int iD, decimal amount, object salesItem, DateTime date)
        {
            throw new NotImplementedException();
        }

        internal void Write()
        {
            throw new NotImplementedException();
        }
    }
}