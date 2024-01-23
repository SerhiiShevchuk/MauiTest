namespace TestMaui.Models
{
    public class ValueModel
    {
        public int Id{ get; set; }

        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is ValueModel m)
            {
                return m.Id == Id;
            }

            return false;
        }
    }
}
