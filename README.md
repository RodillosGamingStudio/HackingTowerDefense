# *Rodillo´s Gaming Studio*

# GAME DESIGN DOCUMENT DE DESKTOP TOWER CHESS


# 1. INTRODUCCIÓN 
## EQUIPO DE DESARROLLO
Nuestro equipo de desarrollo, Rodillo´s Games, está compuesto por los siguientes integrantes:
+ Departamento de <b>Programación</b>: Andrés, Manuel y Javier.
+ Departamento de <b>Diseño</b>: Javier y Laura.
+ Departamento de <b>Arte 3D</b>: Daniel y Laura
+ Departamento de <b>Arte 2D/Concept</b>: Daniel.
<br>

## DESCRIPCIÓN
Un extraño programa ha llegado a parar a tu ordenador y te advierte de que te están hackeando.<br>

Siguiendo sus instrucciones y a través de una su interfaz gráfica de Tower Defense tendrás que ser capaz de protegerlo para que los hackers no roben sus datos.<br>
  
Mientras te enfrentas a los hackers irás descubriendo información sobre ellos y se irá mostrando la verdadera naturaleza del programa.<br>

Cómo uses dicho programa dependerá solamente de ti.<br>
<br>

## OBJETIVO
El objetivo de *Desktop Tower Chess* es proteger tu nuevo programa para evitar que los hackers accedan a él y roben sus datos. Para ello, podrás valerte de una serie de torres en los límites físicos del programa que atacarán a todo agente sospechoso que se acerque por la zona. Dispondrás un terreno finito y tu tarea será gestionar y desplegar las distintas torres con las que cuentes en tu inventario. Pero cuidado, si algún hacker consigue entrar, empezará a robarte información y tu código irá desapareciendo paulatinamente hasta que se adueñen de todo tu programa. <b>¡Debes impedirlo!</b>
<br><br>

## PLATAFORMAS Y REGIONES
*Desktop Tower Chess* será lanzado originalmente para dispositivos móviles y ordenadores.
<br><br>

# 2. ESTRUCTURA DEL JUEGO
## PANTALLAS
El juego dispone de las siguientes pantallas:
+ Escritorio del Sistema Operativo
+ Menú principal
+ Ajustes
+ Créditos
+ Selección de nivel
+ Pantalla de juego (*in-game*)
+ Menú de pausa<br>

La pantalla Escritorio del S.O. solo será accesible la primera vez que se juegue. En adelante, apareceremos siempre en el Menú Principal.<br>

Desde Ajustes, Créditos, Selección de nivel o el mismo juego, podemos regresar al Menú Principal (perdiendo los últimos avances de la partida en el caso de la Pantalla de Juego), y desde él podremos salir de la aplicación.<br>

El Menú de Pausa congelará el juego. Desde él, podremos regresar a él en el último punto o salir al Menú Principal con la consecuente pérdida del avance.<br>

La transición de pantallas es la que se indica en el siguiente diagrama.<br>

<img alt="Pantallas" src="Documentation/DiagramaPantallas.png" width="400">
<br>

## MECÁNICAS DE JUEGO
*Desktop Tower Chess* es un juego estratégico, por lo que las mecánicas son bastantes simples y la experiencia de juego va a depender de la <b>gestión de las unidades en tu inventario</b>.<br>
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
La puntuación del juego se basa por un lado en la obtención de un número de ficheros completos al final del nivel y por otro en el tiempo que se tarde en completar el nivel.<br>
Lo que decidirá el número de ficheros que dar al jugador dependerá de la <b>cantidad de datos restantes</b> al finalizar la partida. Si no se ha superado el nivel, nuestra puntuación será de 0 ficheros, y dependiendo del porcentaje restante, se hará una proporción en la que se asignarán 1, 2, o 3 ficheros (este último caso si nuestro programa conserva el 100% de sus datos).
<br>
El tiempo por otro lado dependerá de la eficiencia en la colocación de las torres de manera que los enemigos se eliminen lo más rápido posible, ya que el tiempo de eliminación de una oleada condiciona la aparición de la siguiente.
<br>

# 3. LOGÍSTICA
## HERRAMIENTAS DE DESARROLLO
Se trata de un videojuego en 3D, por lo que será desarrollado con el motor gráfico *Unity 3D* en su versión 2018.4 respaldado con el IDE *Microsoft Visual Studio 2019* para codificación.<br>
Para la etapa de Concept Art, se utilizará *Adobe Photoshop CC 2018*.
En Modelado se usará *ZBrush* y en Texturización *Substance*.
<br><br>

## MONETIZACIÓN
<p><b>Formato episódico:</b></br> Cada episodio tiene un conjunto de niveles y un personaje (hacker) nuevos sobre los que vas descubriendo información. Según progresa la historia se irá revelando más información sobre el programa.<br>
Los episodios se irán lanzando según se vayan desarrollando, cada uno contará con 3 niveles nuevos, nuevos tipos de torres y enemigos e introducirá a un nuevo personaje, el precio de cada uno de estos episodios será 2.99€.<br></p>

<p>Este precio es el más adecuado porque lo hace algo asequible para el cliente y nos proporcionará una audiencia asegurada en los compradores de los primeros episodios, que deseosos de continuar con la historia seguirán comprando los siguientes.</p>

<p>Estimamos que las horas de trabajo invertidas serán de 104 para el primer episodio (40 de programación, 45 de arte incluyendo concept, modelado y texturizado, 12 de diseño de niveles, 10 de diseño de interfaces y 5 de guión), y que cada episodio adicional llevará 28 horas (1 hora de programación, 10 de arte, 12 de diseño de niveles y 5 de guión).
<br>Basándonos en esta estimación podemos calcular los beneficios por hora que obtendríamos en función de las copias vendidas, como se muestra en la siguiente tabla:

<img alt="Beneficios" src="Documentation/EstimacionBeneficios.png" width="800"><br></p>

<p>A continuación podemos ver una gráfica que ilustra mediante tres estimaciones de ventas (pesimista, más probable y optimista) los beneficios por hora de trabajo en función de las copias vendidas, dependiendo de si se trata del primer capítulo o uno de los consecutivos:

<img alt="GraficaBeneficios" src="Documentation/GraficaBeneficios.png" width="400"><br></p>

<p>Para obtener al menos 10€ de remuneración por cada una de nuestras horas de trabajo necesitaríamos hacer 3 episodios asumiendo que se van a vender 50 copias de cada uno (escenario pesimista), o 2 en el caso del escenario más probable y el optimista, a partir de ahí todas las copias extra y episodios adicionales serían beneficio.<br></p>

## FUTURO DE HACKING TOWER DEFENSE
<p><b>Competitivo: </b></p> 
<p>Una vez salga cada episodio se establecerá un ranking con los jugadores que hayan conseguido las mejores puntuaciones, este ranking se irá actualizando hasta que termine la temporada de dicho capítulo tras lo que se contactará con el mejor jugador para inspirar en él al hacker antagonista del siguiente episodio.<br></p>
<p>El puesto en el ranking  dependerá de la suma de los tiempos obtenidos en los 3 niveles del episodio, de manera que los jugadores para llegar a la cima de la clasificación deberán obtener la máxima puntuación posible en todos los niveles.<br></p>
<p>El ganador además recibirá merchandise e información exclusiva del juego y podrá influir hasta cierto punto en decisiones relativas al diseño del siguiente episodio.<br></p>
<p>De esta manera se crea comunidad tanto en torno al ganador como al propio competitivo en sí, ya que los jugadores tendrán otro aliciente para jugar en llegar a ser el mejor y así ser premiados e incluidos en el juego.
<br></p>

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
