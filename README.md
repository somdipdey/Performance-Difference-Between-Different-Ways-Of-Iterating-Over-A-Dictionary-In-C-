# Performance-Difference-Between-Different-Ways-Of-Iterating-Over-A-Dictionary-In-CSharp (C#)

This program evaluates the performance of three different ways of iterating over a Dictionary in C#.

# The Three Different Method of Iterating Over Dictionary
First, let's assume that the Dictionary variable is as follows:

C#
Dictionary<int, string> profilingDictionary;

## Method1
Using old-school for loop as follows:

C#

        for (int i = 0; i < profilingDictionary.Count; i++ ) 
            { 
                int key = i; 
                string value = profilingDictionary[i]; 
                // Do something here 
            } 
## Method 2
Using foreach lazy coding as follows:

C#

        foreach (var entry in profilingDictionary) 
            { 
                int key = entry.Key; 
                string value = entry.Value; 
                // Do something here 
            }
 
## Method 3
Using foreach non-lazy coding (staticaly typed) as follows:

C#

        foreach (KeyValuePair<int, string> entry in profilingDictionary) 
            { 
                int key = entry.Key; 
                string value = entry.Value; 
                // Do something here 
            }
 
# Performance Difference Between The Three Methods
After running the performance test several times, no doubt the staticaly typed foreach iteration over a Dictionary variable is by far the best performing out of the three.



 
