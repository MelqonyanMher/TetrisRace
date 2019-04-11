# TetrisRace


In this repo I put the famous game from tatris that I wrote myself.



![ezgif com-video-to-gif](https://user-images.githubusercontent.com/49034980/55955000-46c6bc00-5c71-11e9-952c-4f7202c08e95.gif)


You can gave a char in constructor Car() by what car will be drown(if it didn't will be taken defoult character 'O').And after after creating your Car you must call a method Play() for start play.

Example

```csharp
do
{
   char a = (Char)1;
   Car c = new Car(a);
   c.Play();

} while (ReadKey().Key == ConsoleKey.Enter);
```

Have a nice time)))
