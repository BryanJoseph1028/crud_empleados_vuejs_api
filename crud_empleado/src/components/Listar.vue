<template>
        <div class="card">
      <div class="card-header">

      </div>
      <div class="card-body">

        <table class="table">
          <thead>
            <tr>
              <th> ID </th>
              <th> Nombres </th>
              <th> Apellidos </th>
              <th> Direccion </th>
              <th> Telefono </th>
              <th> Puesto</th>
              <th> DPI </th>
              <th> Fecha Nacimiento</th>
              <th> Fecha de Ingreso </th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="empleado in empleados" :key="empleado.id">
              <td>{{empleado.id}}</td>
              <td>{{empleado.nombres}}</td>
              <td>{{empleado.apellidos}}</td>
              <td>{{empleado.direccion}}</td>
              <td>{{empleado.telefono}}</td>
              <td>{{empleado.id_puesto}}</td>
              <td>{{empleado.dpi}}</td>
              <td>{{empleado.fecha_nacimiento}}</td>
              <td>{{empleado.fecha_imgreso}}</td> 
        
              <div class="btn-grouo" role="group" arial-label="">
            <a namne ="button" id="btn_editar" class="btn btn-primary" href="#" role="button">Editar</a>
            <router-link :to="{name='Modificar' ,param:{id:empleado.id}}" | class="btn btn-warning">Editar</router-link>
            <a namne ="button" id="btn_eliminar" v-on:click="borrarEmpleado(empleado.id)" class="btn btn-primary" href="#" role="button">Eliminar</a>
        </div>
        </tr>

          </tbody>

        </table>


  </div>
</div>
   <!-- <div v-for="empleado in empleados" :key="empleado.id">
        <div></div>
        <div></div>
        <div></div>
        <div></div> 
    </div>
    !-->
</template>
<script>
export default{
    data(){

        return{
            empleados:{}
        }
    },

    create:function(){
        
        this.consultarEmpleados();
    },
    methods:{
        //http://localhost:5056
        ConsultarEmpleado(){

            fetch('http://localhost:5056')
            .then(respuesta=>respuesta.json())
            .then((datosRespuesta)=>{
                console.log(datosRespuesta);
                this.empleados=[]
                if(typeof datosRespuesta[0].sucess=='undefinided'){
                    this.empleados=datosRespuesta;
                }


            })
            .catch(console.log())
        },
        borrarEmpleado(id){
            console.log(id);
            fetch('http://localhost:5056/?eliminar='+id)
            .then(respuesta=>respuesta.json())
            .then((datosRespuesta)=>{
                console.log(datosRespuesta);
                window.location.href="Listar"

            })
            .catch(console.log())
        }
    }
}
</script>