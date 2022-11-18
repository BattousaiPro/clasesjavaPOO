package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListAdapter;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivityMostrar extends AppCompatActivity {

    public ListView lista;
    public BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_mostrar);

        lista = findViewById(R.id.lista);
        bdUsuario = new BDUsuario(this);
        ArrayList<Usuario> l = bdUsuario.selectUsiario();

        ArrayList<String> listUser = new ArrayList<>();
        for (Usuario u : l) {
            listUser.add(u.getNombre() + " " + u.getApellido());
        }

        ArrayAdapter<String> a = new ArrayAdapter<>(this, android.R.layout.simple_expandable_list_item_1, listUser);
        lista.setAdapter(a);
    }
}