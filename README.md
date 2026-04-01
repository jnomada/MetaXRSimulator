# MetaXRSimulator
## Cambios

- He descargado unos assets de coches de Unity Store y agregado el prefab a **SceneObjects**. Le quité todos los collider y asigné solo uno en el objecto padre.
- Le añadí un **AudioSource** con un sonido de claxon y lo puse en loop.
- Le añadí el componente **GrabObject** y le puse un Object Name "Car Model".
- Agregué un sistema de particulas como hijo del coche.
- He creado un script "CarController" que tiene referencias al AudioSource y ParticleSystem.  Accede al grabScript y subscribe los métodos de agarrar y soltar. En el método "Grab" asigno al controller la mano/mando que lo haya agarrado. Activo el audiosource y sistema de particulas.
- En la función "Release" desasigno al controller, paro las particulas y el sonido.   

[Repo](https://github.com/jnomada/MetaXRSimulator)
