


namespace AppPropina.Model
{
    using AppPropina.ViewModel;

    public class Propina:Notificable
    {
        private double total;
        private double propinapersona;
        private int personas;
        private double totalneto;
        private double totalpropina;
        private double porcentajepropina;
        private double personastotal;

        public double Total
        {
            get { return total; }
            set
            {
                if (total == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }

       

        public double Propi
        {
            get { return propinapersona; }
            set
            {
                if (propinapersona == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }
      

        public int Personas
        {
            get { return personas; }
            set
            {
                if (personas == value)
                {
                    return;
                }
                OnPropertyChanged();
                 }
        }

     

        public double Neto
        {
            get { return totalneto; }
            set
            {
                if (totalneto == value)
                {

                }
                OnPropertyChanged();
                }
        }
        

        public double TotalPropina
        {
            get { return totalpropina; }
            set
            {
                if (totalpropina == value)
                {
                    return;
                }
                OnPropertyChanged();
                 }
        }
        

        public double PorcentajePropina
        {
            get { return porcentajepropina; }
            set
            {
                if (porcentajepropina == value)
                {
                    return;
                }
                OnPropertyChanged();
            }
        }
       

        public double PersonasTotal
        {
            get { return personastotal; }
            set
            {
                if (personastotal == value)
                {
                    return;
                }
                OnPropertyChanged();
                 }
        }





    }
}
