League Overlay
=====

<p align="center">
    ![LeagueOverlayTransparent](https://user-images.githubusercontent.com/73259429/188216872-fb028e80-2025-4a6e-a369-971d05af113b.png)
</p>

<sub>_Contatct E-mail: yarsted16@gmail.com_</sub>

## Word of introduction

Even if I think it's safe for use I will remind you that **I take no responisbility** if software will became detected over time. 
<br>**_FOR ADDITIONAL SAFETY:_**
  * _Change the name of executable_
  * _Track changes in Riot term of serivces_

### What is it?

The aim of the project was to make **simple overlay** as counteraction for possible bans linked with porofessor camp timers revealing.
<br><sub>_There was some rumors about Riot banning players after some changes in their term of services. More informations here (it's in Polish)
  https://boop.pl/league-of-legends/rybson-alarmuje-ze-dostaniecie-za-to-perma-bana-w-lolu-uzywa-tego-masa-osob_</sub> 
 
### Application features
 
  - Jungle timers minimap overlay
  - Positioning overlay manualy for any minimap size
  - Saving config and loading it
  - Launching timers by keystrokes
  - Launching timers by voice recognition
  - Turning off/on keybinds helper overlay


### How to use it

  1. You must compile it by yourself (see down below) or download compiled zip package from release tab
  2. After initial launch you must go to system tray icons and change the positions of timers.
  3. In window that will pop up, select camp from combo box and position it accordingly to camps on your league of legends minimap
  4. Use "Save to config" button to save positions to config.
  5. After lauching again, lauch changing positions again and click Load from config.

**If you want to use voice recognition:**
  * You must **launch application AS ADMINISTRATOR!**
  * You must turn it on in tray icon. Use left side for left jungle side and vice versa
  * **Recognized words: `"frog, wolves, raptors, krugs"`**
  * You must pronounce words clearly to make its effectivness better

-----------

### Compiling

If you decide to compile source code by yourself, there will be no documentation in config. When changing values in keybinding be **sure to use C# type `"Keys"` as values** otherwise I think it would crash in some cases.
<br>If you'd like to see small config documentation, just download release package in zip file and see `LeagueOverlay.exe.config` file

* Download source code and compile it

-----------------------------------------

### Problems and unresolved issues

I have implemented some basic voice recognition for project. It works most of the time, be sure to pronounce words clearly. For more information about voice recognition see "How to use it" section.
<br>
<br>Coming back to the point: 
  * Sometimes it can work poorly (not recognize words or even recognize "raptors" as "krugs")
  * I didn't make option "Turn off voice recognition" work so you can't quit voice recognition mode
  * It is not tested for any normal long game. Feedback will be appreciated 🤗

<br>
Sorry for not refactoring code, I admit that most of it is a mess. I should add more classes with its own purposes. Additionaly chunks of code are in my native     language, I was too lazy sometimes and didn't translate it.


## A word about detection

This software **is not** using any chunk of memory that is contained in the game. It doesn't read nor do write to it. Im not a specialist but the only thing that riot can do is: **seek for this particular executable** in running processes OR they can build a detection on **applications that are hooking APIs needed for reading keystrokes**.


#### Screenshots

<p align="center">
  <img align="center" width="600" height="600" src="https://i.imgur.com/H0Ha8xU.png">
</p>
<p align="center">
  <img align="center" width="600" height="600" src="https://i.imgur.com/mKiefdj.png">
</p>
<p align="center">
  <img align="center" width="600" height="600" src="https://i.imgur.com/Qb7FKPj.png">
</p>



