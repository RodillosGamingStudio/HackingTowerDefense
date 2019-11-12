# *Rodillo´s Gaming Studio*

# GAME DESIGN DOCUMENT DE HACKING TOWER DEFENSE


# 1. INTRODUCCIÓN 
## EQUIPO DE DESARROLLO
Nuestro equipo de desarrollo, Rodillo´s Games, está compuesto por los siguientes integrantes:
+ Departamento de <b>Programación</b>: Andrés, Manuel y Javier.
+ Departamento de <b>Diseño</b>: Javier y Laura.
+ Departamento de <b>Modelado y Texturización</b>: Daniel y Laura
+ Departamento de <b>Arte</b>: Daniel.
<br>

## DESCRIPCIÓN
Has creado un programa que de salir a a la luz cambiará la realidad tal y como la conocemos. Viendo lo peligroso que puede llegar a ser decides no compartirlo con el mundo, pero después de todo tu trabajo no te sientes capaz de destruirlo.<br>
Ahora varios hackers tratan de robar los datos de tu programa y solo podrás protegerlo mediante uno de los protocolos que forman parte de él, el protocolo TOWER.<br>
Mientras te enfrentas a los hackers irás descubriendo información sobre ellos y se irá mostrando el verdadero propósito del programa. Puede que incluso cambies de opinión sobre su uso.
<br>

## OBJETIVO
El objetivo de *Hacking Tower Defense* es proteger tu nuevo programa para evitar que los hackers accedan a él y te roben datos. Para ello, podrás valerte de una serie de torres en los límites físicos del programa que atacarán a todo agente sospechoso que se acerque por la zona. Dispondrás un terreno finito y tu tarea será gestionar y desplegar las distintas torres con las que cuentes en tu inventario. Pero cuidado, si algún hacker consigue entrar, empezará a robarte información y tu código irá desapareciendo paulatinamente hasta que se adueñen de todo tu programa. <b>¡Debes impedirlo!</b>
<br><br>

## PLATAFORMAS Y REGIONES
*Hacking Tower Defense* será lanzado originalmente para dispositivos móviles y ordenadores.
<br><br>

# 2. ESTRUCTURA DEL JUEGO
## PANTALLAS
El juego dispone de las siguientes pantallas:
+ Menú principal
+ Ajustes
+ Créditos
+ Selección de nivel
+ Pantalla de juego (*in-game*)
+ Menú de pausa
Desde Ajustes, Créditos, Selección de nivel o el mismo juego, podemos regresar al Menú Principal (perdiendo los últimos avances de la partida en el caso de la Pantalla de Juego), y desde él podremos salir de la aplicación.<br>
El Menú de Pausa congelará el juego. Desde él, podremos regresar a él en el último punto o salir al Menú Principal con la consecuente pérdida del avance.<br>
La transición de pantallas es la que se indica en el siguiente diagrama.<br>
<img alt="Pantallas" src="Documentation/DiagramaPantallas.png" width="400">
<br>

## MECÁNICAS DE JUEGO
*Hacking Tower Defense* es un juego estratégico, por lo que las mecánicas son bastantes simples y la experiencia de juego va a depender de la <b>gestión de las unidades en tu inventario</b>.<br>
Cuando vayas superando mapas, se te irán entregando nuevas y diferentes torres cuya actuación respecto a los enemigos es distinta. Algunos valores mejoran, y otros empeoran. E incluso aparecen algunos nuevos. La responsabilidad del jugador será sopesar los atributos de las torres defensivas y su efectividad contra los distintos tipos de enemigos que podrán ir apareciendo.
<br>

## CONTROLES
<p>Los controles serán puramente táctiles en el caso de móviles, y clickeando en el caso de ordenadores. <br>
La transición entre pantallas se conseguirá mediante click en los botones de la interfaz. Asimismo, la colocación de torres en el mapa se realizará igual.</p>
<br>

## TIPOS DE TORRES
<p><b>Torre básica</b><br>
- Dispara a un solo objetivo de manera intermitente<br>
- Velocidad de disparo: rápida<br>
- Coste: bajo<br>
<img alt="torre_basica_concept" src="Images/torre_basica_concept.png" width="400"></p>
<p><b>Torre en área</b><br>
- Sus ataques cubren un área en el que dañan a todos los objetivos<br>
- Velocidad de disparo: lenta<br>
- Coste: medio<br>
<img alt="torre_en_area_concept" src="Images/torre_en_area_concept.png" width="400"></p></p>
<p><b>Torre ralentizadora</b><br>
- Sus ataques cubren un área pero no hacen daño sino que reducen la velocidad de los enemigos<br>
- Velocidad de disparo: media<br>
- Coste: medio<br>
<img alt="torre_ralentizadora_concept" src="Images/torre_ralentizadora_concept.png" width="400"></p></p>
<p><b>Torre de rayos</b><br>
- Dispara de manera continua y sus ataques afectan a un solo objetivo<br>
- Coste: alto<br>
<img alt="torre_rayos_concept" src="Images/torre_rayos_concept.png" width="400"></p></p>
<p><b>NOTA:</b> Todas las torres disparan al primer objetivo que entra a su rango hasta que sale del mismo, después seleccionan al siguiente más adelantado dentro de su rango</p>
<br>

## MEJORAS PARA LAS TORRES
- Mayor velocidad de disparo
- Mayor daño por disparo
- Mayor rango
- Disparo a múltiples objetivos simultáneamente (por ejemplo para la de rayos)
<br>

## TIPOS DE ENEMIGOS
<p><b>Básico</b><br>
- Velocidad: lenta<br>
- Vida: media<br>
- Coste: 1<br></p>
<p><b>Tanque</b><br>
- Velocidad: lenta<br>
- Vida: alta<br>
- Coste: 5<br></p>
<p><b>Sanador</b><br>
- Velocidad: media<br>
- Vida: media<br>
- Restaura vida a otras unidades dentro de su rango de manera periódica<br>
- Coste: 3<br></p>
<p><b>Corredor</b><br>
- Velocidad: rápida<br>
- Vida: baja<br>
- Coste: 2<br></p>
<p><b>Volador</b><br>
- Velocidad: media<br>
- Vida: media<br>
- Al ser volador no le afectan las torres ralentizadoras ni en área<br>
- Coste: 1<br></p>

<p>El coste es el daño que produce un enemigo al llegar a la base que se está defendiendo. En otras palabras los datos que se han robado sobre el total de los datos.<br>
Cada vez que un enemigo sea derrotado devolverá su coste como moneda.</p>
<br>

## MAPAS
Los mapas del juego variarán según el nivel en el que estés. Son espacios estáticos y con un recorrido pre-establecido.<br>
Pero cada partida será diferente, pues las combinaciones de enemigos serán aleatorias, consiguiendo que el jugador deba emplear diferentes estrategias según las circunstancias.
<br><br>

## PUNTUACIÓN
La puntuación del juego se basa en la obtención de un número de entre ninguna o 5 estrellas, siendo 0 la peor puntuación y 5 la mejor.<br>
Lo que decidirá el número de estrellas que dar al jugador dependerá de la <b>vida del programa</b> al finalizar la partida. Si no se ha superado el nivel, nuestra puntuación será de 0 estrellas, y dependiendo del porcentaje restante, se hará una proporción en la que se asignarán 1, 2, 3, 4 o 5 estrellas (este último caso si nuestro programa conserva el 100% de su vida.
<br>

# 3. LOGÍSTICA
## HERRAMIENTAS DE DESARROLLO
Se trata de un videojuego en 3D, por lo que será desarrollado con el motor gráfico *Unity 3D* respaldado con el IDE *Microsoft Visual Studio 2019* para codificación.<br>
Para la etapa de Concept Art, se utilizará *Adobe Photoshop CC 2018*.
En Modelado se usará *ZBrush* y en Texturización *Substance*.
<br><br>

## MONETIZACIÓN
<p><b>Formato episódico:</b> cada episodio tiene un conjunto de niveles y personajes (hackers) sobre los que vas descubriendo información. Según progresa la historia se irá revelando más información sobre el programa.
Los episodios se irán lanzando según se vayan desarrollando con un precio preestablecido para todos.<br></p>

<p><b>Booklet de concept:</b> por un pequeño extra puedes obtener un libro con el arte original del juego y comentarios sobre los diseños, así como contenido extra que amplía el del juego.<br></p>
<br>

## FUTURO DE HACKING TOWER DEFENSE
<p><b>DLC Modo multijugador:</b> en este modo el objetivo será aguantar más tiempo que el rival, de manera que consigas robar todos su datos sin que él robe los tuyos.<br></p>

<p><b>DLC Editor de escenarios:</b> en este modo puedes crear tus propios escenarios, y configurar los enemigos para compartirlos con otros jugadores o jugarlos tú mismo.<br></p>
<br>

## HOSTING
El hosting del proyecto se hará en <b>*Git*</b>, del que podrán nutrirse *Facebook* e *itch.io*
<br><br>

# 4. CONTACTO
## MAIL, PLATAFORMAS INDIES Y REDES SOCIALES
+ Facebook: Rodillo´s Gaming<br>
facebook.com/rodillos.gaming.9

+ Twitter: @RodillosGaming<br>
twitter.com/RodillosGaming

+ itch.io: Rodillos Gaming<br>
rodillos-gaming.itch.io/

+ Youtube: Rodillos Gaming<br>
youtube.com/channel/UCUaR00AHGi0U2Z7mT9jfVfw

+ email: rodillosgaming@gmail.com
<br>

<b>¡GRACIAS POR JUGAR! :)</b>
