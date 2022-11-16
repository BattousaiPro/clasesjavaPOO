package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivityRegistrar extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_registrar);
        us = (EditText)fileList(R.id.RegUsuario);
        pass = (EditText)fileList(R.id.RegPass);
        nom = (EditText)fileList(R.id.RegNombre);
        ap = (EditText)fileList(R.id.RegApellido);
        reg = (EditText)fileList(R.id.RegRegistrar);
        can = (EditText)fileList(R.id.btn_Entar);
        reg.setOnClickListener(this);
        can.setOnClickListener(this);
    }
    public void onClick(View v){
        switch (v.getId()){
            case R.id.btn_Registrar:
                Usuario u = new Usuario();
                u.setUsuario(us.getText().toString());
                u.setPassword(us.getText().toString());
                u.setNombre(us.getText().toString());
                u.setApellido(us.getText().toString());
                if (!u.isNull()){
                    Toast.makeText(this, "ERROR Campos Vacios", Toast.LENGTH_LONG).show();
                }else if (bdUsuario.inserUsuario(u)){
                    Toast.makeText(this,"Registro Exitoso", Toast.LENGTH_LONG).show();
                    Intent i1 = new Intent(MainActivityRegistrar.this,MainActivity.class);
                    startActionMode(i1);
                    finish();
                }else {
                    Toast.makeText(this, "Usuario ya Registrado", Toast.LENGTH_LONG).show();
                }
                break;
            case R.id.btn_Entar:
                Intent i = new Intent(MainActivityRegistrar.this, MainActivity.class);
                startActivity(i);
                break;
        }
    }
}