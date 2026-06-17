using Proyecto_Final_POO;
using System;
using System.Windows.Forms;

static class Program
{
    public static string[] usuarios = new string[100];
    public static string[] passwords = new string[100];
    public static string[] nombres = new string[100];
    public static string[] roles = new string[100];
    public static int contadorUsuarios = 0;

    public static string usuarioActivo = "";
    public static string nombreActivo = "";
    public static string rolActivo = "";

    public static string[] libros = {
        "Programación en C#", "Base de Datos SQL",
        "Física Universitaria", "Cálculo Integral",
        "Principios de Administración", "Gestión Empresarial",
        "Contabilidad de Costos", "Auditoría Financiera",
        "Derecho Civil", "Constitución Política",
        "Psicología Clínica", "Procesos Cognitivos"
    };
    public static string[] ids = {
        "INF-01", "INF-02",
        "ING-01", "ING-02",
        "ADM-01", "ADM-02",
        "CON-01", "CON-02",
        "DER-01", "DER-02",
        "PSI-01", "PSI-02"
    };
    public static string[] pasillos = {
        "Pasillo A", "Pasillo A",
        "Pasillo B", "Pasillo B",
        "Pasillo C", "Pasillo C",
        "Pasillo D", "Pasillo D",
        "Pasillo E", "Pasillo E",
        "Pasillo F", "Pasillo F"
    };
    public static string[] secciones = {
        "Sección 1", "Sección 2",
        "Sección 1", "Sección 2",
        "Sección 1", "Sección 2",
        "Sección 1", "Sección 2",
        "Sección 1", "Sección 2",
        "Sección 1", "Sección 2"
    };
    public static string[] estantes = {
        "Estante 3", "Estante 4",
        "Estante 1", "Estante 2",
        "Estante 5", "Estante 1",
        "Estante 2", "Estante 3",
        "Estante 4", "Estante 5",
        "Estante 1", "Estante 2"
    };

    public static string libroSeleccionado = "";
    public static string idSeleccionado = "";
    public static string pasilloSeleccionado = "";
    public static string seccionSeleccionado = "";
    public static string estanteSeleccionado = "";
    public static string diasRentaSeleccionado = "";

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Program.nombres[0] = "Administrador";
        Program.usuarios[0] = "admin";
        Program.passwords[0] = "12345";
        Program.roles[0] = "Estudiante";
        Program.contadorUsuarios = 1;

        Application.Run(new Form1());
    }
}