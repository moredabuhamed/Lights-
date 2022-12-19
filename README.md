# Lights-
University project
There are light poles placed in a park. The positions (xi, yi) of light pole i is known as well as
its range r (all lamps have the same range which is an odd number). A light pole illuminates a
square shaped area with the pole in its midpoint. Illuminated areas are safe, while dark areas
are unsafe for people.
Develop a console application in C# to determine a safe path from point p1 to point p2 in the
park. This path is a sequence of co-ordinates of the park’s fields. Any element of this path can
only be followed by a neighboring field (upper, lower, left or right neighbor).
The data of the light poles are stored in the file lights.in. In its first line there is the
number of light poles N, the width and height of the rectangular park and the ranges of lamps.
The next N lines are the positions of poles separated by semicolons. Field that are out of the
park can be ignored.
the application should determine and visualize an optimal path from position p1 to p2 given
by the user. Also, design and implement a nice-looking user interface for the application using
console graphics.
Use object-oriented programming for both desing and implementation!
Example.
lights.in
8;10;3;5
3;3
7;3
3;9
Green fields marked by „S” are safe (illuminated) fileds, red ones with „U” are unsafe (dark)
fields. If p1 is (1, 2) and p2 is (7, 8) then blue fields show a possible optimal path (there are
many of them with the same number of unsafe fields).





![Capture](https://user-images.githubusercontent.com/54741656/208548788-6fdc82ce-3ae5-49d8-bba4-24c64a0cfc60.PNG)
