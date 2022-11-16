package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        user=(EditText) findViewById(R.id.User);
        pass=(EditText) findViewById(R.id.RegApellido);
        btnEntrar=(EditText)findViewById(R.id.btn_Entrar);
        btnRegistar=(EditText)findViewById(R.id.btn_Registar);
        btnEntrar.setOnClckListener(this);
        btnRegistrar.setOnClckListener(this);
        bdUsuario = new BDUsuario(this);
    }
    public void onClick(View v){
        switch (v.getId()){
            case R.id.btn_Entrar:
                String u = user.getText().toString();
                String p = pass.getText().toString();
                if (u.equals("")&&p.equals(""));{
                Toast.makeText(this, "ERROR : Campos Vacios", Toast.LENGTH_LONG).show();
            }else if (bdUsuario.long(u,p)==1){
                    Usuario us = bdUsuario.getUsuario(u,p);
                    Toast.makeText(this, "Datos Correctos",Toast.LENGTH_LONG).show();
                    Intent i2 = new Intent(MainActivity.this, MainActivityInicio.class);
                    i2.putExtra("id", us.getId());
                    startActivity(i2);
            }
                break;
            case R.id.btn_Registrar:
                Intent i = new Intent(MainActivity.this,MainActivityRegistrar.class);
                startActivity(i);
                break;
        }
    }
}