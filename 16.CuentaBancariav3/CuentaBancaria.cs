namespace _14.CuentaBancaria{
    class CuentaBancaria{
        protected double saldo; //Permmite que sea accedido por las clases que heredan

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public double Saldo{
            get { return saldo;}
        }

        public void Depostia(double cantidad){
            saldo+=cantidad;
        }

        //metodo virtualque podra ser sobrecargado por la clase que lo herede
        public virtual bool Retira(double cant){
            if(saldo>cant){
                saldo-=cant;
                return true;
            }else return false;
        }
    }
}