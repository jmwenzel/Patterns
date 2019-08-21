Strategy Pattern
================

 

Definition
----------

The Strategy design pattern defines a family of algorithms, encapsulates each
one as an object and makes them interchangeable at run time.  
Strategy lets the algorithm vary independently from clients that use it.

 

Applicability
-------------

Use the Strategy pattern when:

-   There are multiple related classes that only differ in their behavior
    execution.

-   You need different variants of an algorithm.

-   A class defines many behaviors and these appear as multiple conditional
    statements in its operations. Instead of many conditionals,move related
    conditional branches into their own Strategy class.

 

Structure
---------

![](https://raw.githubusercontent.com/jmwenzel/imagecollection/master/strategy.png?token=AEIP6TYOOMLUNPGQMFTNCIK5LRWKW)

-   **Strategy:** Declares an interface common to all supported algorithms.
    Context uses this interface to call the algorithm defined by a
    ConcreteStrategy.

-   **ConcreteStrategy:** Implements the algorithm using the Strategy interface.

-   **Context:** It is configured with a ConcreteStrategy object, maintains a
    reference to a Strategy object
