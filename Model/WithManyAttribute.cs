namespace ajaychouhan11.Model
{
    internal class WithManyAttribute : Attribute
    {
        private string v;
        public WithManyAttribute(string v)
        {
            this.v = v;
        }
    }
}