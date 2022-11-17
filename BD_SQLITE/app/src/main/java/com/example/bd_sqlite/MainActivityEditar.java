package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivityEditar extends AppCompatActivity implements View.OnClickListener {
    EditText EdiUser;
    EditText EdiPass;
    EditText EdiNom;
    EditText EdiApe;
    Button btnActualizar;
    Button btnRegistrar;
    int id = 0;
    Usuario u;
    BDUsuario bdUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_editar);

        EdiUser = findViewById(R.id.EditUsuario);
        EdiPass = findViewById(R.id.EditPass);
        EdiNom = findViewById(R.id.EditNombre);
        EdiApe = findViewById(R.id.EditApellido);
        btnActualizar = findViewById(R.id.btn_Actualizar);
        btnRegistrar = findViewById(R.id.btn_Registrar);
        btnActualizar.setOnClickListener(this);
        btnRegistrar.setOnClickListener(this);

        Bundle b = getIntent().getExtras();
        id = b.getInt("ID");
        u = bdUsuario.getUsuarioID(id);
        EdiUser.setText(u.getUsuario());
        EdiPass.setText(u.getPassword());
        EdiNom.setText(u.getNombre());
        EdiApe.setText(u.getApellido());
    }

    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btn_Actualizar:
                u.setUsuario(EdiUser.getText().toString());
                u.setPassword(EdiPass.getText().toString());
                u.setNombre(EdiNom.getText().toString());
                u.setApellido(EdiApe.getText().toString());

                if (!u.isNull()) {
                    Toast.makeText(this, "ERROR : Campos Vacios ", Toast.LENGTH_LONG).show();
                } else if (bdUsuario.updateUsuario(u)) {
                    Toast.makeText(this, "Actualizacion Exitosa", Toast.LENGTH_LONG).show();
                    Intent i1 = new Intent(MainActivityEditar.this, MainActivityInicio.class);
                    i1.putExtra("ID", u.getId());
                    startActivity(i1);
                    finish();
                } else {
                    Toast.makeText(this, "No Se Puede Actualizar", Toast.LENGTH_LONG).show();


                }
                break;
            case R.id.btn_Registrar:
                Intent a2 = new Intent(MainActivityEditar.this, MainActivity.class);
                a2.putExtra("ID", u.getId());
                startActivity(a2);
                finish();
                break;
        }
    }
}