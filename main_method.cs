// Some valid declarations of Main Method in a C# program:

// With command line arguments:


using System; 
  
class New { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        Console.WriteLine("Main Method"); 
    } 
} 

// Without Command line arguments:


using System; 
  
class New1 { 
  
    // Main Method 
    static public void Main() 
    { 
  
        Console.WriteLine("Main Method"); 
    } 
} 

// Applicable Access Modifiers:


using System; 
  
class New2 { 
  
    // Main Method 
    protected static void Main() 
    { 
  
        Console.WriteLine("Main Method"); 
    } 
} 



using System; 
  
class New3 { 
  
    // Main Method 
    private protected static void Main() 
    { 
  
        Console.WriteLine("Main Method"); 
    } 
} 

// Without any access modifier:


using System; 
  
class New4 { 
  
    // Main Method without any 
    // access modifier 
    static void Main() 
    { 
  
        Console.WriteLine("Main Method"); 
    } 
} 
