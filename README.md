
Coding Challenge IOL

Estimados, 
Dejo el desarrollo con las correspondientes modificaciones acatando las consignas mencionadas.

El código fue re-factorizado, se aplicó primeramente la Herencia, se agregaron archivos de recursos por cada idioma.
Con solo setear el idioma al inicio del método IMPRIMIR es suficiente para la utilización del mismo,
sin necesidad de aplicar N cantidad de IF y haciendo que el seguimiento del código sea sencillo.
Se agrego el idioma Aleman, las palabras utilizadas fueron buscadas por el traductor de Google.
De las 160 líneas de código que había en la Clase FormaGeometrica se redujo a 94 líneas,
se agregaron clases hijas donde se define el comportamiento de cada Forma, sin tener que modificar la misma
 cuando haya una nueva implementación. Cumpliendo con el principio Open por Extension, Close por Modification. 

Investigue una forma de hacer una traducción con un idioma Base sin tener que usar los archivos de recursos,
pero iba a requerir más tiempo de análisis y pruebas, por lo que opte, en esta instancia, por este método. 