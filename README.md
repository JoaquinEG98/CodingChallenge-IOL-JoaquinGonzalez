## Esta es mi solución para el Coding Challenge!

Primero que nada, encontré varias soluciones a este problema. Al principio pensé en implementar el Patrón de Diseño Strategy, pero me encontré con una limitación: no se pueden agregar instancias de Figuras a una lista de FormaGeometrica porque Cuadrado no sería una subclase de FormaGeometrica.
Una solución a este problema, es cambiar la clase FormaGeometrica para que sea genérica y acepte como parámetro el tipo de forma geométrica que se quiere utilizar pero el código era más dificil de leer.

Otra solución que encontré es utilizar el Patrón de Diseño Chains of Responsability, pero la desventaja que tiene es que el código es más complicado de seguir y también a medida que se van agregando más figuras geométricas, el rendimiento empeora, ya que cada solicitud debe pasar por toda la cadena.

Con estas soluciones el código no quedaba muy legible, por lo que lo realicé de diferente manera. Hice que FormaGeometrica sea una clase abstracta y que las figuras hereden esta clase, teniendo que implementar los métodos CalcularArea() y CalcularPerimetro(). También desacoplé los modulos, separé los reportes de las figuras geométricas, ya que cada clase debería encargarse de una sola responsabilidad.

Creé otra clase abstracta llamada Reporte, en donde están hechos los cálculos de las formas según el tipo. Además, cree una subclase llamada "GeneradorReporte" en donde hereda de Reporte, implementando obligatoriamente el método Imprimir(). Este método solo es necesario modificarlo si se agrega una nueva figura, para agregar un nuevo StringBuilder.

En cuanto a los idiomas, creé una nueva clase llamada "Traducciones". Dentro de esta lo que hice fue crear un diccionario con todos los idiomas, por lo que si se desea agregar uno, lo unico que se debe hacer es agregar un nuevo tipo de idioma con su traducción al diccionario. En caso de que se pase un idioma que no existe al generar los reportes, utilizará el idioma default que es el Español.

## A tener en cuenta
Tuve que actualizar los paquetes NuGet de los tests ya que no me funcionaban. Si les da error, lo que hay que hacer es borrar la carpeta Packages que se encuentra en la raíz de la solución.

Además, los tests podrían fallar según la cultura de la computadora que tengan al momento de correrlos. Por ejemplo, a mi los decimales me los pone con punto en vez de coma. Dejé los tests para los dos tipos de cultura, sólo que dejé comentada la cultura en inglés por si las necesitan cambiar.



Eso es todo, muchas gracias por darme la posibilidad de realizar este challenge.
Saludos!
