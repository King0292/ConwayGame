# Juego de la Vida de Conway

Este proyecto es una implementación en C# del famoso **Juego de la Vida** de John Conway, una simulación de autómatas celulares que representa cómo evoluciona una población en función de reglas simples.

## Descripción del proyecto

El **Juego de la Vida** es un juego de simulación donde cada celda en una cuadrícula puede estar viva o muerta.

### Reglas del Juego:
1. Una célula viva con menos de 2 vecinos vivos muere por subpoblación.
2. Una célula viva con 2 o 3 vecinos vivos sigue viva.
3. Una célula viva con más de 3 vecinos vivos muere por sobrepoblación.
4. Una célula muerta con exactamente 3 vecinos vivos revive por reproducción.

## Cómo ejecutar
1. Clona el repositorio: `git clone https://github.com/King0292/conwaygame` o descarga el .zip
2. Abre el proyecto en Visual Studio o cualquier editor C#.
3. Compila y ejecuta el programa.
