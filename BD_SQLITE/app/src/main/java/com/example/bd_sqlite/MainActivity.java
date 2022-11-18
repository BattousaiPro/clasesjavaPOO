package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    public EditText user;
    public EditText pass;
    public EditText textPrueba;
    public Button btnEntrar;
    public Button btnRegistrar;
    public BDUsuario bdUsuario;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        user = (EditText) findViewById(R.id.User);
        pass = (EditText) findViewById(R.id.RegApellido);
        textPrueba = (EditText) findViewById(R.id.textoPrueba);
        btnEntrar = (Button) findViewById(R.id.btn_Entrar);
        btnRegistrar = (Button) findViewById(R.id.btn_Registrar);
        bdUsuario = new BDUsuario(this);

        btnEntrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textPrueba.setText("");
                String u = user.getText().toString();
                String p = pass.getText().toString();
                if (u.equals("") && p.equals("")) {
                    textPrueba.setText("elementos vacios");
                    Toast.makeText(getApplicationContext(), "ERROR : Campos Vacios", Toast.LENGTH_LONG).show();
                } else if (bdUsuario.login(u, p) == 1) {
                    textPrueba.setText("Login Okey");
                    Usuario us = bdUsuario.getUsuario(u, p);
                    Toast.makeText(getApplicationContext(), "Datos Correctos", Toast.LENGTH_LONG).show();
                    Intent i2 = new Intent(MainActivity.this, MainActivityMostrar.class);
                    i2.putExtra("id", us.getId());
                    startActivity(i2);
                } else {
                    textPrueba.setText("Else");
                }
            }
        });
        btnRegistrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(MainActivity.this, MainActivityRegistrar.class);
                startActivity(i);
            }
        });

    }

/*
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btn_Entrar:
                String u = user.getText().toString();
                String p = pass.getText().toString();
                if (u.equals("") && p.equals("")) {
                    Toast.makeText(this, "ERROR : Campos Vacios", Toast.LENGTH_LONG).show();
                } else if (bdUsuario.login(u, p) == 1) {
                    Usuario us = bdUsuario.getUsuario(u, p);
                    Toast.makeText(this, "Datos Correctos", Toast.LENGTH_LONG).show();
                    Intent i2 = new Intent(MainActivity.this, MainActivityMostrar.class);
                    i2.putExtra("id", us.getId());
                    startActivity(i2);
                }
                break;
            case R.id.btn_Registrar:
                Intent i = new Intent(MainActivity.this, MainActivityRegistrar.class);
                startActivity(i);
                break;
        }
    }
    */
}