# marzo30

* 2003 Primera version
* 2005 Webforms (ASP.NET)
* 2008 ADO.NET + LINQ2SQL  (LINQ)
* 2010 
  * Entity framework (EF)  = ADO.NET + LINQ
  * MVC (ASP.NET + webforms)
  
* SOAP (Web Service) -> WCF (Windows Communication Foundation) -> WebApi

## MVC

Sirve principalmente para mostrar paginas web. Pero tambien puede entregar valores para procesarse.

* **Router**

  * dominio.dom/Cliente/Insertar
    * Cliente = va a llamar al controlador ClienteController.
    * Insertar = va a llamar a la funcion o metodo Insertar

  ```c#
  class ClienteController {
      public void Insertar() {
          // nuestro codigo
      }
  }
  ```

* **Controlador**

  * Dentro del controlador esta el modelo (Model)

* **Vista**

  * El modelo se muestra en la vista (Model)

### Razor

La notacion Razor se ocupa en la vista.  

Puede trabajar en conjunto con ASP.NET

```html
<!-- razor -->
{{variable}}   
{!! variable !!}
@funcion()
<!-- asp.net -->
<%  // codigo c#  %>
    


```

## WebApi

Es similar a MVC, pero solamente devuelve datos.



## Microsoft Identity (seguridad)







