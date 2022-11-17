package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListAdapter;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivityMostrar extends AppCompatActivity {

    ListView lista;
    BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_mostrar);

        lista = findViewById(R.id.lista);
        bdUsuario = new BDUsuario(this);
        ArrayList<Usuario> l = bdUsuario.selectUsiario();

        ArrayList<String> list = new ArrayList<>();
        for (Usuario u : l) {
            list.add(u.getNombre() + " " + u.getApellido());
        }

        ArrayAdapter<String> a = new ArrayAdapter<>(this, android.R.layout.simple_expandable_list_item_1, lista);
        lista.setAdapter(a);
    }
}