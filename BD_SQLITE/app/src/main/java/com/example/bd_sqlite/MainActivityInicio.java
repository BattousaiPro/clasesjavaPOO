package com.example.bd_sqlite;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivityInicio extends AppCompatActivity implements View.OnClickListener {
    Button btnEditar, btnEliminar, btnMostrar, btnSalir;
    TextView nombre;
    int id = 0;
    Usuario u;
    BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_activityinicio);

        nombre = findViewById(R.id.nombreUsuario);
        btnEditar = findViewById(R.id.Editar);
        btnMostrar = findViewById(R.id.Mostrar);
        btnSalir = findViewById(R.id.Salir);
        btnEditar.setOnClickListener(this);
        btnEliminar.setOnClickListener(this);
        btnMostrar.setOnClickListener(this);
        btnSalir.setOnClickListener(this);

        Bundle b = getIntent().getExtras();
        id = b.getInt("ID");
        u = bdUsuario.getUsuarioID(id);
        nombre.setText(u.getNombre() + " " + u.getApellido());
    }

    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.Editar:
                Intent a = new Intent(MainActivityInicio.this, MainActivityEditar.class);
                a.putExtra("id", id);
                startActivity(a);
                break;
            case R.id.Eliminar:
                AlertDialog.Builder b = new AlertDialog.Builder(this);
                b.setMessage("¿Esta Seguro De Eliminar La Cuenta?");
                b.setCancelable(false);
                b.setPositiveButton("SI", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        if (bdUsuario.deleteUsuario(id)) {
                            Toast.makeText(MainActivityInicio.this, "Se Elimino Correcta Mente", Toast.LENGTH_LONG).show();
                            Intent b = new Intent(MainActivityInicio.this, MainActivity.class);
                            startActivity(b);
                            finish();
                        } else {
                            Toast.makeText(MainActivityInicio.this, "No Se Elimino La Cuenta", Toast.LENGTH_LONG).show();
                        }
                    }
                });
                b.setNegativeButton("NO", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        dialogInterface.cancel();
                    }
                });
                b.show();
                break;
            case R.id.Mostrar:
                Intent c = new Intent(MainActivityInicio.this, MainActivity.class);
                startActivity(c);
                break;
            case R.id.Salir:
                Intent d = new Intent(MainActivityInicio.this, MainActivity.class);
                startActivity(d);
                break;
        }
    }
}