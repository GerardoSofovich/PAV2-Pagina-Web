var app = angular.module("tareasApp", []);

app.controller("tareasController", function ($scope, $http) {
    $scope.tipos = [];
    $scope.tareas = [];
    $scope.modoEditar = false;

    $scope.nueva = function () {
        $scope.modoEditar = true;
        $scope.tarea = {
            Id: 0,
            Nombre: "",
            FechaVencimiento: new Date(),
            Completado: false
        };

    };
    $scope.editar = function (t) {
        $scope.modoEditar = true;
        $scope.tarea = t;
    };
    $scope.guardar = function () {
        if ($scope.tarea.id === 0) {
            $http.post("/api/tareas", $scope.tarea).then(function (response) {
                    //la tarea se agregócon exitp
                    cargarTareas();
                }
            );
        }
        else {
            $http.put("/api/tareas/" + $scope.tareas.id, $scope.tarea).then(function (response) {
                //la tarea se modificó con éxito
                cargarTareas();
                }
            );

        };
        $scope.modoEditar = false;
    };
    $scope.cancelar = function () {
        $scope.modoEditar = false;
    };
    $scope.eliminar = function (t) {
        if (confirm("desea eliminar la tarea: " + t.Nombre + " ?")) { };

    };


    $scope.cargarTipos = function () {
        $http.get("/api/tipos").then(
            function (response) {
                $scope.tipos = response.data;
            });
    };
    $scope.cargarTareas = function () {
        var idTipo = 0;
        if ($scope.buscarTipo) {
            var idTipo = $scope.buscarTipo.Id;
        };
        var params = { idTipo: idTipo, completado: true };
        $http.get("/api/tareas", {params:params}).then(
            function (response) {
                $scope.tareas = response.data;
            });
    };

    $scope.cargarTareas();
    $scope.cargarTipos();

}
);