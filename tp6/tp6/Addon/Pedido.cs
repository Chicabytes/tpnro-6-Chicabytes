namespace tp6
{
    public enum EstadoPedido
    {
        Todos = -1,
        Recibido = 0,
        Preparado = 1,
        EnCamino = 2,
        Entregado = 3
    }

    public class Pedido
    {
        private int numpedido;
        private string obs;
        private EstadoPedido estado_actual;
        private Cliente nCliente;
        private Cadete cadete;

        public int Numpedido { get => numpedido; set => numpedido = value; }
        public string Obs { get => obs; set => obs = value; }
        public EstadoPedido Estado_actual { get => estado_actual; set => estado_actual = value; }
        public Cliente NCliente { get => nCliente; set => nCliente = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

        public void NuevoPedido(int _numpedido, string _obs, int _estado)
        {
            Numpedido = _numpedido;
            Obs = _obs;
            switch (_estado)
            {
                case 0:
                    Estado_actual = EstadoPedido.Recibido;
                    break;
                case 1:
                    Estado_actual = EstadoPedido.Preparado;
                    break;
                case 2:
                    Estado_actual = EstadoPedido.EnCamino;
                    break;
                case 3:
                    Estado_actual = EstadoPedido.Entregado;
                    break;
            }
        }
        public override string ToString()
        {
            return " Numero de pedido: " + Numpedido + "\n Observacion: " + Obs + "\n Estado del Pedido: " + Estado_actual.ToString();
        }
    }
}
