using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios_de_Herencia
{
    public partial class _Default : Page
    {
        List<Persona> humano = new List<Persona>();
        List<Profesor> esclavo_del_estado = new List<Profesor>();
        List<Alumno> esclavo_del_profesor = new List<Alumno>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}