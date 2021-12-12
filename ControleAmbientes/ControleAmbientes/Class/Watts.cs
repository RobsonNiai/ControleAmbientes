namespace ControleAmbientes.Class
{
    public class Watts
    {
        public string ID { get; set; }
        public string POT { get; set; }


        public Watts() { }

        public Watts(string id, string pot)
        {
            POT = pot;
            ID = id;
        }

    }
}
