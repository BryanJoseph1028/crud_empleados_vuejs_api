<template>
    <template>
    <div class="container">
    <div class="card">
        <div class="card-header">
            <h1> modificarempleados</h1>
        </div>
            <div class="card-body"> 
                <form v-on:submit.prevent="modificarRegistro">
                <div class="mb-3">
                <label for="lbl_nombre" class="form-label">nombres</label>
                 <input type="text" class="form-control" v-model="empleado.nombre" id="txt_nombre" preholder="NOMBRE NOMBRE" >
                </div>
                <div class="mb-3">
                <label for="lbl_apellidos" class="form-label">Apellidos</label>
                 <input type="text" class="form-control" v-model="empleado.apellido" id="txt_direccion" preholder="APELLIDO APELLIDO">
                </div>
                <div class="mb-3">
                <label for="lbl_direccion" class="form-label">Direccion</label>
                 <input type="text" class="form-control" v-model="empleado.direccion" id="txt_direccion">
                </div>
                <div class="mb-3">
                <label for="lbl_telefono" class="form-label">Telefono</label>
                <input type="number" class="form-control" v-model="empleado.telefono" id="txt_telefono">
                </div>
                <div class="mb-3">
                <label for="lbl_puesto" class="form-label">puesto</label>
                 <input type="text" class="form-control" v-model="empleado.id_puesto" id="txt_puesto">
                </div>
                <div class="mb-3">
                <label for="lbl_dpi" class="form-label">DPI</label>
                 <input type="text" class="form-control" v-model="empleado.dpi" id="txt_dpi">
                </div>
                <div class="mb-3">
                <label for="lbl_fn" class="form-label">fecha nacimiento</label>
                 <input type="date" class="form-control" v-model="empleado.fecha_nacimiento" id="txt_fn">
                </div>
                <div class="mb-3">
                <label for="lbl_fi" class="form-label">fecha de ingreso</label>
                 <input type="text" class="form-control" v-model="empleado.fecha_ingreso" id="fi">
                </div>
                 <button type="submit" id="btn_agregar" class="btn btn-primary">Agregar</button>
                 <button type="button"  id ="btn_cancelar" class="btn btn-warning">Cancelar</button>
                <router-link :to="(name='Listar')" class="btn btn-warning">Cancelar</router-link>
                </form>

            </div>
        </div>
    </div>
</template>
<script>
export default{
    data(){
        return{
            empleados:{}
        }
    },
    created:function(){

    },
    methods:{
        obtenerInformacion(){
            fetch('http://localhost:5056/?consultar='+this.$route.param.id)
            .then(respuesta=>respuesta.json())
            .then((datosRespuesta)=>{
                console.log(datosRespuesta);
                this.empleados=[]
                if(typeof datosRespuesta[0].sucess=='undefinided'){
                    this.empleados=datosRespuesta[0];
                }
            })
            .catch(console.log())
              },
              actualizarRegistro(){
                var datosEnviar ={id:this.empleado.id,nombre:this.empleado.nombre,apellidos:this.empleado.apellidos,direccion:this.empleado.direccion,telefono:this.empleado.telefono,id_puesto:this.empleado.id_puesto,dpi:this.empleado.dpi,fecha_nacimiento:this.empleado.fecha_nacimiento,fecha_omgreso:this.empleado.fecha_ingreso}
            fetch('http://localhost:5056/?actualizar=1'+this.$route.params.id,{
                methos="POST"
                body:JSON.stringify(datosEnviar)
            })
            .then(respuesta=>respuesta.json())
            .then((datosRespuesta=>{
                console.log(datosRespuesta);
                window.location.href='Crear'

            }))
              }
        }
    }
</script>