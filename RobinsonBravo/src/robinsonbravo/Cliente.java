package robinsonbravo;

public class Cliente {

    private int idCliente;
    private int cargo;
    private int ciudad;
    private int tarjetasQueosee;

    public Cliente() {
    }

    public Cliente(int idCliente, int cargo, int ciudad, int tarjetasQueosee) {
        this.idCliente = idCliente;
        this.cargo = cargo;
        this.ciudad = ciudad;
        this.tarjetasQueosee = tarjetasQueosee;
    }

    public void setIdCliente(int idCliente) {
        this.idCliente = idCliente;
    }

    public void setCargo(int cargo) {
        this.cargo = cargo;
    }

    public void setCiudad(int ciudad) {
        this.ciudad = ciudad;
    }

    public void setTarjetasQueosee(int tarjetasQueosee) {
        this.tarjetasQueosee = tarjetasQueosee;
    }

    public int getIdCliente() {
        return idCliente;
    }

    public int getCargo() {
        return cargo;
    }

    public int getCiudad() {
        return ciudad;
    }

    public int getTarjetasQueosee() {
        return tarjetasQueosee;
    }

    @Override
    public String toString() {
        return "Persona{"
                + "idCliente=" + idCliente
                + ", cargo=" + cargo
                + ", ciudad=" + ciudad
                + ", tarjetasQueosee=" + tarjetasQueosee
                + '}';
    }

}
