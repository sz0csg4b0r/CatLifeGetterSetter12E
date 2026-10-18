namespace CatLife.Model
    {
    internal class Macska
        {
        //Adattagok - autoproperties
        private string _nev;
        private double _suly;
        private bool _ehes;

        public string Nev
            {
            get => _nev;

            set
                {
                if (string.IsNullOrWhiteSpace(value))
                    {
                    throw new ArgumentException("A macskának kell, hogy legyen neve!");
                    }
                string tisztitott = value.Trim();
                _nev = char.ToUpper(tisztitott[0]) + tisztitott.Substring(1);
                }
            }

        public double Suly
            {
            get { return _suly; }
            set
                {
                if (value < 1.0)
                    {
                    _suly = 1.0;
                    }
                else if (value > 12.0)
                    {
                    _suly = 12.0;
                    }
                else
                    {
                    _suly = value;
                    }
                }
            }

        public bool Ehes { get => _ehes; set => _ehes = value; }

        public Macska(string nev, double suly, bool ehes)
            {
            Nev = nev;
            Suly = suly;
            Ehes = ehes;
            }

        public Macska(string nev, double suly)
            {
            Nev = nev;
            Suly = suly;
            Ehes = true;
            }

        public bool Eszik(double etel)
            {
            if (Ehes)
                {
                Suly = Suly + etel;
                Ehes = false;
                return true;
                }
            else
                {
                return false;
                }
            }

        public void Futkos()
            {
            Suly = Suly - 0.4;
            if (!Ehes)
                {
                Ehes = true;
                }
            }
        public override string ToString()
            {
            string ehesseg;
            if (Ehes)
                {
                ehesseg = "éhes";
                }
            else
                {
                ehesseg = "nem éhes";
                }

            return $"{Nev}, {Suly:F2} kg, {ehesseg}";
            }
        }
    }
