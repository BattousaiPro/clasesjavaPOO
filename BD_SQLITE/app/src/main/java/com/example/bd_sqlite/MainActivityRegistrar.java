package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivityRegistrar extends AppCompatActivity implements View.OnClickListener {

    EditText us, pas, nom, ap;
    Button reg, can;
    BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_registrar);
        us = (EditText) findViewById(R.id.RegUsuario);
        pas = (EditText) findViewById(R.id.RegPass);
        nom = (EditText) findViewById(R.id.RegNombre);
        ap = (EditText) findViewById(R.id.RegApellido);
        reg = (Button) findViewById(R.id.btn_Registrar);
        can = (Button) findViewById(R.id.btn_Entrar);
        reg.setOnClickListener(this);
        can.setOnClickListener(this);
    }

    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btn_Registrar:
                Usuario u = new Usuario();
                u.setUsuario(us.getText().toString());
                u.setPassword(us.getText().toString());
                u.setNombre(us.getText().toString());
                u.setApellido(us.getText().toString());
                if (!u.isNull()) {
                    Toast.makeText(this, "ERROR Campos Vacios", Toast.LENGTH_LONG).show();
                } else if (bdUsuario.updateUsuario(u)) {
                    Toast.makeText(this, "Registro Exitoso", Toast.LENGTH_LONG).show();
                    Intent i1 = new Intent(MainActivityRegistrar.this, MainActivity.class);
                    startActivity(i1);
                    finish();
                } else {
                    Toast.makeText(this, "Usuario ya Registrado", Toast.LENGTH_LONG).show();
                }
                break;
            case R.id.btn_Entrar:
                Intent i = new Intent(MainActivityRegistrar.this, MainActivity.class);
                startActivity(i);
                break;
        }
    }
}