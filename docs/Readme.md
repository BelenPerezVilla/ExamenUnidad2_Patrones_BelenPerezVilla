# Documentacion del proyecto: Simulador de Trafico de Ciudad
# **Nombre: Belen Perez Villa**
# **Numero de control: 21212579**
# **Fecha: 17/10/25**
---
# Introduccion
El proyecto Simulador de trafico de ciudad tiene como objetivo representar de forma simplificada la coordinacion del trafico urbano
mediante una simulacion en consola en C#.
Esta simulacion muestra como los vehiculos, sensores y los semaforos interatuan entre si bajo la direccion de un controlador central
que gestiona el flujo vehicular para optimizar la circulacion.

El sistema tiene un diseño que aplica dos patrones de diseño: `Object Pool` y `Singleton`.
- Use el patron singleton, para garantizar un unico punto de cotrol central.
- El patron object pool, para reutilizar eficientemente objetos en la simulacion (vehiculos y sensores)
---
# *Objetivo del proyecto*
Hacer un simulador de control de trafico para una ciudad utilizando principios de diseño orientado a objetos y 
los patrones de diseño.

---
# Patrones de diseño implementados
`Patron Singleton - CentralControl`
- Garantizar que solo exista una unica instancia del controlador de trafico en todo el sistema
     - La clase `CentralControl` contiene como atributo estatico `instance` y un metodo public `instancia` que devuelve siempre la misa referencia
     - El constructor es privado, impidiendo la creacion de mas instancias.
  - *Beneficio*: evitar conflictos de control y asegura un unico punto de coordinacion del trafico.
`Patron Objetect Pool - VehiculoPool y SensorPool`
- Reutilizamos los objectos que se crean frecuentemente para que mejore el rendimiento y reducir la carga de memoria.
- Los Vehiculos (`Vehiculo`) y sensores (`Sensor`) se cream una sola vez al inicio
- Cada ciclo, el sistema toma el objeto pool y los marca como "en uso", y al finalizar, los libera.
- *Beneficio*: Tenemos una simulacion en tiempo real mas eficiente y una gestion optima de recursos.
---
# Ejecucion
<img width="881" height="376" alt="image" src="https://github.com/user-attachments/assets/263baf32-7d84-4fa7-b948-c52dbe19d38e" />
<img width="769" height="497" alt="image" src="https://github.com/user-attachments/assets/56f1c0e2-a4cc-4c14-ac84-c30c266061ec" />
<img width="775" height="624" alt="image" src="https://github.com/user-attachments/assets/84dc78ec-4fdf-4480-aefb-613191755202" />
<img width="761" height="508" alt="image" src="https://github.com/user-attachments/assets/8e277c91-cabf-4de6-a6f7-b8cf11e7bee8" />
<img width="746" height="606" alt="image" src="https://github.com/user-attachments/assets/f5e2cb17-0b8b-4668-b5fb-8c15ae0c47ea" />

---
# Conclusion
En este proyecto se demostro el uso practico de los patrones en un contexto poco realista y didactico, el uso del patron `Singleton` nos asegura un control
centralizado y de esta forma evita la duplicacion de instancias, mientras el otro patron `Object Pool` que optimiza el rendimiento y el manejo eficiente de los objetos reutilizados.
Atreves de la implementacion de los patrones se logra que el sistema sea mas estructuradom eficiente y una manera mas facil de mantener, que optimiza el uso de recursos y garantiza
una correcta coordinacion de los elementos de trafico.

Como resultado final de esta simulacion nos demuestra que los principios de diseño se pueden aplicarse en un entorno mas dinamito como la gestion
del trafico urbano. Este proyecto no solos refuerza el conocimiento de los patrones y de esta forma optimizar los tiempos de los semafors.
