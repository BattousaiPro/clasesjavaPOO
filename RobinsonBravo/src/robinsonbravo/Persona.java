
package robinsonbravo;

import java.util.Date;

public class Persona {
    private String rut;
    private String nombre;
    private String apellido;
    private Date fecha_nacimiento;
    private String estadoCivil;
    private String sexo;

    public Persona(String rut, String nombre, String apellido, Date fecha_nacimiento, String estadoCivil, String sexo) {
        this.rut = rut;
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecha_nacimiento = fecha_nacimiento;
        this.estadoCivil = estadoCivil;
        this.sexo = sexo;
    }

    public Persona() {
    }

    public String getRut() {
        return rut;
    }

    public String getNombre() {
        return nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public Date getFecha_nacimiento() {
        return fecha_nacimiento;
    }

    public String getEstadoCivil() {
        return estadoCivil;
    }

    public String getSexo() {
        return sexo;
    }

    public void setRut(String rut) {
        this.rut = rut;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void setFecha_nacimiento(Date fecha_nacimiento) {
        this.fecha_nacimiento = fecha_nacimiento;
    }

    public void setEstadoCivil(String estadoCivil) {
        this.estadoCivil = estadoCivil;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }

}
