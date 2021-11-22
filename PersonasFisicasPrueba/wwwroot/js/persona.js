$(document).ready(function () {
    cargarDataTable();

});
var dataTable;

function cargarDataTable() {
    dataTable = $('#tblPersona').DataTable({
        "ajax": {
            "type": "GET",
            "datatype": "json",
            "url": "/Main/PerFisicas/GetAllAPI"
        }, 
        "columns": [
            { "data": "idPersonaFisica", "width": "5%" },
            {
                "data": "fechaRegistro"
            },
            {
                "data": "fechaActualizacion"
            },
            {
                "data": "idPersonaFisica", "width": "20%", "render": function (data, type, row, meta) {
                    return row.apellidoPaterno + ' ' + row.apellidoMaterno + ' ' + row.nombre
                }
            },


            {
                "data": "rfc"
            },
            {
                "data": "fechaNacimiento"
            },
            {
                "data": "usuarioAgrega"
            },

            {
                "data": "idPersonaFisica",
                "width": "25%",
                "render": function (data) {
                    return `<div class="text-center"><a class="btn btn-primary" href="/Main/PerFisicas/Edit/${data}">Editar</a>&nbsp;<a class="btn btn-danger text-white" style="cursor:pointer;" onclick="Delete('/Main/PerFisicas/Delete/${data}')">Eliminar</a> </div>`
                }
            },
        ],
    });
}

function Delete(urlDestino) {
    console.log(urlDestino);
    swal({
        title: "¿Estas seguro que deseas borrar a la Persona?",
        text: "Esta accion no se puede revertir",
        type: "warning",
        showCancelButton: true,
        confirmButtonText: "Si, borrar",
        closeOnConfirm: true
    },
        function () { 
            $.ajax({
                type: "DELETE",
                url: urlDestino,
                success: function (response) {
                    if (response.success == true) {
                        toastr.success(response.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(response.message);
                    }
                }

            });
        }
    );

  

}
