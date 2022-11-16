package com.example.bd_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivityEditar extends AppCompatActivity implements View.OnClickListener {
    EditText EdiUser, EdiPass, EdiNom, EdiApe;
    Button btnActualizar, btnCancelar;
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
        btnActualizar.setOnClickListener(this);
        btnCancelar.setOnClickListener(this);

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
            case R.id.btn_EditActualizar:
                u.setUsuario(EdiUser.getText().toString());
                u.setPassword(EdiPass.getText().toString());
                u.setNombre(EdiNom.getText().toString());
                u.setApellido(EdiApe.getText().toString());

                if (!u.isNull(u)) {
                    Toast.makeText(this, "ERROR : Campos Vacios ", Toast.LENGTH_LONG).show();
                } else if (bdUsuario.updateUsuario(u)) {
                    Toast.makeText(this, "Actualizacion Exitosa", Toast.LENGTH_LONG).show();
                    Intent i1 = new Intent(MainActivityEditar.this, MainActivityInicio.class);
                    i1.putExtra("ID", u.getId());
                    startActivity(i1);
                    finish();
                } else {
                    Toast.makeText(this, "No Se Puede Actualizar", Toast.LENGTH_LONG).show();

                    case R.id.btn_EditCancerlar:
                        Intent a2 = new Intent(MainActivityEditar.this, MainActivity.class);
                        i2.putExtra("ID", u.getId());
                        startActivity(i2);
                        finish();
                        break;
                }

        }
    }
}