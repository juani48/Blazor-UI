namespace UI.Entidades;

public class Cliente
{
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public int Edad { get; set; }

    public static List<Cliente> GetClientes(){
        return new List<Cliente> {
            new Cliente() {Nombre="Pablo",Apellido="Perez", Edad=34},
            new Cliente() {Nombre="Laura",Apellido="García", Edad=30},
            new Cliente() {Nombre="José",Apellido="Lopez", Edad=45},
            new Cliente() {Nombre="Ana",Apellido="Colombo", Edad=21},
            new Cliente() {Nombre="María",Apellido="Suarez", Edad=15}};
    }
}
