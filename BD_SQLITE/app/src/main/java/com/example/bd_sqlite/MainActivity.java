package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    EditText user, pass;
    Button btnEntrar, btnRegistrar;
    BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        user = (EditText) findViewById(R.id.User);
        pass = (EditText) findViewById(R.id.RegApellido);
        btnEntrar = (Button) findViewById(R.id.btn_Entrar);
        btnRegistrar = (Button) findViewById(R.id.btn_Registrar);
        btnEntrar.setOnClickListener(this);
        btnRegistrar.setOnClickListener(this);
        bdUsuario = new BDUsuario(this);
    }

    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btn_Registrar:
                String u = user.getText().toString();
                String p = pass.getText().toString();
                if (u.equals("") && p.equals("")) {
                    Toast.makeText(this, "ERROR : Campos Vacios", Toast.LENGTH_LONG).show();

                } else if (bdUsuario.login(u, p) == 1) {
                    Usuario us = bdUsuario.getUsuario(u, p);
                    Toast.makeText(this, "Datos Correctos", Toast.LENGTH_LONG).show();
                    Intent i2 = new Intent(MainActivity.this, MainActivityInicio.class);
                    i2.putExtra("id", us.getId());
                    startActivity(i2);
                }
                break;
            case R.id.btn_Entrar:
                Intent i = new Intent(MainActivity.this, MainActivityRegistrar.class);
                startActivity(i);
                break;
        }
    }
}