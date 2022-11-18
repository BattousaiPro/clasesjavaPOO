package com.example.bd_sqlite;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;

public class BDUsuario {
    Context globalContext;
    ArrayList<Usuario> lista;
    SQLiteDatabase sql;
    String bd = "BDusuaio";
    String table = "create table if not exists usuario(id integer primary key autoincrement, usuario text, pass text, nombre text, apellido text)";

    public BDUsuario(Context context) {
        this.globalContext = context;
        sql = context.openOrCreateDatabase(bd, context.MODE_PRIVATE, null);
        sql.execSQL(table);
    }

    public boolean updateUsuario(Usuario usuario) {
        if (buscar(usuario.getUsuario()) == 0) {
            ContentValues cv = new ContentValues();
            cv.put("usuario", usuario.getUsuario());
            cv.put("pass", usuario.getPassword());
            cv.put("nombre", usuario.getNombre());
            cv.put("apellido", usuario.getApellido());
            return (sql.insert("usuario", null, cv) > 0);
        } else {
            return false;
        }
    }

    public boolean deleteUsuario(int id) {
        return (sql.delete("Usuario", "id" + id, null) > 0);
    }

    public int buscar(String userName) {
        int x = 0;
        lista = selectUsiario();
        for (Usuario us : lista) {
            if (us.getUsuario().equals(userName)) {
                x++;
            }
        }
        return x;
    }

    public ArrayList<Usuario> selectUsiario() {
        ArrayList<Usuario> lista = new ArrayList<Usuario>();
        lista.clear();
        Cursor cr = sql.rawQuery("select * from usuario", null);
        if (cr != null && cr.moveToFirst()) {
            do {
                Usuario u = new Usuario();
                u.setId(cr.getInt(0));
                u.setUsuario(cr.getString(1));
                u.setPassword(cr.getString(2));
                u.setNombre(cr.getString(3));
                u.setApellido(cr.getString(4));
                lista.add(u);
            } while (cr.moveToFirst());
        }
        return lista;
    }

    public int login(String userName, String password) {
        int a = 0;
        Cursor cr = sql.rawQuery("select * from usuario", null);
        if (cr != null && cr.moveToFirst()) {
            do {
                if (cr.getString(1).equals(userName)
                        && cr.getString(2).equals(password)) {
                    a++;
                }
            } while (cr.moveToFirst());
        }
        return a;
    }

    public Usuario getUsuario(String userName, String password) {
        lista = selectUsiario();
        for (Usuario us : lista) {
            if (us.getUsuario().equals(userName) && us.getPassword().equals(password)) {
                return us;
            }
        }
        return null;
    }

    public Usuario getUsuarioID(int id) {
        lista = selectUsiario();
        for (Usuario us : lista) {
            if (us.getId() == id) {
                return us;
            }
        }
        return null;
    }
}
