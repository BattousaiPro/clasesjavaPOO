package robinsonbravo;

import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;
import java.util.Date;

public class Cliente extends Persona{

    private int idCliente;
    private int cargo;
    private String ciudad;
    private String tarjetasQuePosee;
    private int edad;

    public Cliente() {
    }

    public Cliente(int idCliente, int cargo, String ciudad, String tarjetasQuePosee, int edad, String rut, String nombre, String apellido, Date fecha_nacimiento, String estadoCivil, String sexo) {
        super(rut, nombre, apellido, fecha_nacimiento, estadoCivil, sexo);
        this.idCliente = idCliente;
        this.cargo = cargo;
        this.ciudad = ciudad;
        this.tarjetasQuePosee = tarjetasQuePosee;
        this.edad = edad;
    }

    public Cliente(int idCliente, int cargo, String ciudad, String tarjetasQuePosee, int edad) {
        this.idCliente = idCliente;
        this.cargo = cargo;
        this.ciudad = ciudad;
        this.tarjetasQuePosee = tarjetasQuePosee;
        this.edad = edad;
    }

    

    public void setIdCliente(int idCliente) {
        this.idCliente = idCliente;
    }

    public void setCargo(int cargo) {
        this.cargo = cargo;
    }

    public void setCiudad(String ciudad) {
        this.ciudad = ciudad;
    }

    public void setTarjetasQuePosee(String tarjetasQuePosee) {
        this.tarjetasQuePosee = tarjetasQuePosee;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public int getEdad() {
        return edad;
    }

    public int getIdCliente() {
        return idCliente;
    }

    public int getCargo() {
        return cargo;
    }

    public String getCiudad() {
        return ciudad;
    }

    public String getTarjetasQuePosee() {
        return tarjetasQuePosee;
    }

    public void calcularEdad(String fecha) {

        DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        // super.getFecha_nacimiento()
        LocalDate fechaNac = LocalDate.parse(fecha, fmt);
        LocalDate ahora = LocalDate.now();

        Period periodo = Period.between(fechaNac, ahora);
        System.out.printf("Tu edad es: %s años, %s meses y %s días", periodo.getYears(), periodo.getMonths(), periodo.getDays());

        this.edad = periodo.getYears();
    }

    @Override
    public String toString() {
        return "Cliente{"
                + "idCliente=" + idCliente
                + ", cargo=" + cargo
                + ", ciudad=" + ciudad
                + ", tarjetasQuePosee=" + tarjetasQuePosee
                + ", edad=" + edad
                + '}';
    }

}
