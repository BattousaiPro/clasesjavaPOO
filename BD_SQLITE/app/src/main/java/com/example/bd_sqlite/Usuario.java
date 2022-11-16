package com.example.bd_sqlite;

public class Usuario {
    private Integer id;
    private String Nombre;
    private String Apellido;
    private String Usuario;
    private String Password;

    public Usuario() {
    }

    public boolean isNull() {
        if (Nombre.equals("")
                && Apellido.equals("")
                && Usuario.equals("")
                && Password.equals("")
        ) {
            return false;
        } else {
            return true;
        }
    }

    @java.lang.Override
    public java.lang.String toString() {
        return "Usuario{" +
                "id=" + id +
                ", Nombre='" + Nombre + '\'' +
                ", Apellido='" + Apellido + '\'' +
                ", Usuario='" + Usuario + '\'' +
                ", Password='" + Password + '\'' +
                '}';
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String apellido) {
        Apellido = apellido;
    }

    public String getUsuario() {
        return Usuario;
    }

    public void setUsuario(String usuario) {
        Usuario = usuario;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String password) {
        Password = password;
    }

    Nombre = nombre;
    }
}
