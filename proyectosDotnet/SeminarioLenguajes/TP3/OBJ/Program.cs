using System;

namespace OBJ
{


    class Program
    {
        //definir una clase persona, definir 15 caracteristicas que hacen a una persona, con estructuras de arreglos o listas segun convenga, para representar: gustos, hobbies, lista de amigos, familiares, estado de sus relaciones, horarios
        //definir atributos de lo mas diversos, para representar todas las caracteristicas posibles de una persona,y metodos para cambiar y obtener sus valores, y MUCHO MAS TODO LO QUE TE PUEDAS IMAGINAR
        //definir subclases para las caracteristicas que presenten demasiada similitud al representarlas y para hacer mas sencilla la implementacion de las mismas, pudiendo tambien interactuar entre si, y poder crear objetos de estas subclases
        


        static void Main(string[] args)
        {
            public class Actividad()
            {

                
                public string nombreActividad;
                public string descripcionActividad;
                public float tiempoActividad;

            }
            
            public class Persona()
            {
                public string nombre;

                public string apellido;

                public string fechaNacimiento;

                public float peso;
                public float altura;
                public string estadoCivil;
                public string nacionalidad;
                public string religion;
                

                public float sueldo;
                public string profesion;
                public string lugarTrabajo;
                public string cargo;
                public string telefono;
                public string direccion;
                public string correo;
                

                

            


                public string[] gustos;
                public string[] hobbies;
                public List<Persona> amigos;
                public List<Persona> conocidos;
                public List<Persona> familiares;
                public List<Persona> relaciones;



                public List<Actividades>[][] horarios;
                public List<Tarea> tareas;
                public List<Actividad> actividades;
                public List<Reunion> reuniones;
                public List<Evento> eventos;
                public List<Nota> notas;
                public List<Contacto> contactos;
                public List<Mensaje> mensajes;

                public Persona(string nombre, string apellido, string fechaNacimiento, string[] gustos, string[] hobbies, List<Amigo> amigos, List<Familiar> familiares, List<Relacion> relaciones, List<Horario> horarios, List<Tarea> tareas, List<Actividad> actividades, List<Reunion> reuniones, List<Evento> eventos, List<Nota> notas, List<Contacto> contactos, List<Mensaje> mensajes)
                {
                    this.nombre = nombre;
                    this.apellido = apellido;
                    this.fechaNacimiento = fechaNacimiento;
                    this.gustos = gustos;
                    this.hobbies = hobbies;
                    this.amigos = amigos;
                    this.familiares = familiares;
                    this.relaciones = relaciones;
                    this.horarios = horarios;
                    this.tareas = tareas;
                    this.actividades = actividades;
                    this.reuniones = reuniones;
                    this.eventos = eventos;
                    this.notas = notas;
                    this.contactos = contactos;
                    this.mensajes = mensajes;
                }

                public Persona()
                {
                    this.nombre = "";
                    this.apellido = "";
                    this.fechaNacimiento = "";
                    this.gustos = new string[0];
                    this.hobbies = new string[0];
                    this.amigos = new List<Amigo>();
                    this.familiares = new List<Familiar>();
                    this.relaciones = new List<Relacion>();
                    this.horarios = new List<Horario>();
                    this.tareas = new List<Tarea>();
                    this.actividades = new List<Actividad>();
                    this.reuniones = new List<Reunion>();
                    this.eventos = new List<Evento>();
                    this.notas = new List<Nota>();
                    this.contactos = new List<Contacto>();
                    this.mensajes = new List<Mensaje>();
                }

                public Persona(string nombre, string apellido, string fechaNacimiento)
                {
                    this.nombre = nombre;
                    this.apellido = apellido;
                    this.fechaNacimiento = fechaNacimiento;
                }

                public void setNombre(string nombre)
                {
                    this.nombre = nombre;
                }

                public string getNombre()
                {
                    return this.nombre;
                }

                public void setApellido(string apellido)
                {
                    this.apellido = apellido;
                }                                                                                           

                public string getApellido()
                {
                    return this.apellido;
                }

                public void setEdad(int edad)
                {
                    this.edad = edad;
                }
                
                public int getEdad()
                {
                    return this.edad;
                }

                public void setSexo(string sexo)
                {
                    this.sexo = sexo;
                }


                public string getSexo()
                {
                    return this.sexo;
                }

                public void setGustos(string[] gustos)
                {
                    this.gustos = gustos;
                }

                public string[] getGustos()
                {
                    return this.gustos;
                }


                public void setHobbies(string[] hobbies)
                {
                    this.hobbies = hobbies;
                }


                public string[] getHobbies()
                {
                    return this.hobbies;
                }


                public void setAmigos(List<Amigo> amigos)
                {
                    this.amigos = amigos;
                }

                
                public List<Amigo> getAmigos()
                {
                    return this.amigos;
                }


                public void setFamiliares(List<Familiar> familiares)
                {
                    this.familiares = familiares;
                }

                
                public List<Familiar> getFamiliares()
                {
                    return this.familiares;
                }


                public void setRelaciones(List<Relacion> relaciones)
                {
                    this.relaciones = relaciones;
                }



                public List<Relacion> getRelaciones()
                {
                    return this.relaciones;
                }


                public void setHorarios(List<Horario>[][] horarios)
                {
                    this.horarios = horarios;
                }


                public List<Horario>[][] getHorarios()
                {
                    return this.horarios;
                }


                public void setTareas(List<Tarea> tareas)
                {
                    this.tareas = tareas;
                }


                public List<Tarea> getTareas()
                {
                    return this.tareas;
                }


                public void setActividades(List<Actividad> actividades)
                {
                    this.actividades = actividades;
                }


                public List<Actividad> getActividades()
                {
                    return this.actividades;
                }


                public void setReuniones(List<Reunion> reuniones)
                {
                    this.reuniones = reuniones;
                }


                public List<Reunion> getReuniones()
                {
                    return this.reuniones;
                }


                public void setEventos(List<Evento> eventos)
                {
                    this.eventos = eventos;
                }

                public void getEventos()
                {
                    return this.eventos;
                }

                
                public void setNotas(List<Nota> notas)
                {
                    this.notas = notas;
                }


                public List<Nota> getNotas()
                {
                    return this.notas;
                }



                public void setContactos(List<Contacto> contactos)
                {
                    this.contactos = contactos;
                }


                public List<Contacto> getContactos()
                {
                    return this.contactos;
                }


                public void setMensajes(List<Mensaje> mensajes)
                {
                    this.mensajes = mensajes;
                }


                public List<Mensaje> getMensajes()
                {
                    return this.mensajes;
                }


                public void setFechaNacimiento(string fechaNacimiento)
                {
                    this.fechaNacimiento = fechaNacimiento;
                }


                public string getFechaNacimiento()
                {
                    return this.fechaNacimiento;
                }


                //Para el atributo eventos, un evento es cualquier suceso en la vida de la persona,

                //por ejemplo, una cita, una reunión, una actividad, una tarea, etc.

                //Para el atributo reuniones, una reunión es una reunión de una persona con otra persona,

                //por ejemplo, una reunión con un amigo, una reunión con un familiar, una reunión con un contacto, etc.

                //Para el atributo actividades, una actividad es una actividad que realiza una persona,

                //por ejemplo, una actividad de trabajo, una actividad de estudio, una actividad de recreación, etc.
                public void agregarEvento(Evento evento)
                {
                    this.eventos.Add(evento);
                }

                //realizar un metodo que calcule el tiempo disponible de la persona en un dia dado, mediante una matriz de horarios, cada elemento es un dia representado como un arreglo de actividades con distintas duraciones

                public calcularTiempoDisponible(string fecha)
                {

                    //recorrer la matriz de horarios y calcular el tiempo disponible en ese dia restando la duracion total de las actividades, al numero 16

                    for(int i = 0; i <
                    

                }

            }
  
        }
    }

    }
