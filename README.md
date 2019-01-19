# Zoo
Using all 4 of the Object Oriented Principles (OOPs): - Build out the hierarchical class structure of a zoo within Visual Studio and a digital diagram. - There should be at least 3 layers of inheritance with at least 6 different types of animals.

# Requirements
3 different abstract classes
3 layers of inheritance
5 concrete animals
2 abstract methods
2 abstract properties
2 virtual methods (override one of them)
2 virtual properties (override one of them)

# Diagram
markup: ![classes info](/Assets/zoo2.JPG)

# Explanation of OOP Principles
1. Abstraction: It allows making relevant information visible. Abstract classes are non-instantiable classes.
2. Inheritance: The class that inherits the members of the base class is called the derived class. This allows derived class to inherit properties from base methods.
3. Encapsulation: Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. Encapsulation, in object oriented programming methodology, prevents access to implementation details. (e.g., public, private, protected, etc.).
4. Polymorphism: It is the ability of objects of different types to provide a unique interface for different implementations of methods. It is usually used in the context of late binding, where the behavior of an object to respond to a call to its method members is determined based on object type at run time. It  allows virtual properties and methods in base classes to be overridden in children or derived classes. 


# Interface
In C# a class can only inherit from one type but can implement many interfaces. So interfaces allow you to fulfill multiple contracts in one class. 
Interface helps a class to include behavior from multiple sources. C# is an object oriented language and it does not support multiple inheritance of classes. 
Interface can contain methods, properties, events, indexers or any combination of these members. 
To implement an interface member, the corresponding member of the implementing class must be public, non-static, and have the same name and signature as the interface member.

In my code I created two interfaces, <IHuntWaterAndLand> and <ICanSwim>. The have differnt methods inside of them that are not present in the base class. 
This helps me to write less codes, if I need to have similar methods or properties in multiple classes or concretes. 
Both my Tiger and Gharial can swim but those properties are not inherited. Interface helps in better organization of my code. 