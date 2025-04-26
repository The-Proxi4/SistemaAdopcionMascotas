using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult FormularioMascota()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RegistrarMascota(string nombre, int edad, string tipo, string estadoAdopcion)
    {
        // Aquí puedes agregar la lógica para guardar la mascota en la base de datos.

        // Redirigir o devolver una vista de éxito.
        return RedirectToAction("MascotasRegistradas");
    }

    public IActionResult MascotasRegistradas()
    {
        // Aquí puedes recuperar todas las mascotas registradas y mostrarlas.
        return View();
    }
}
