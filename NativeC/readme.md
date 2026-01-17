Linking type

1. Dynamic Linking

Link the shared library during compile time and load during runtime.
For this the os need to know where to look for dynamic library.


## Compiling shared library

`
gcc -shared -fPIC libmyfunc.c \
    -o libmyfunc.dylib \
    -install_name @rpath/libmyfunc.dylib
`
```
```

## Compiling program using the shared library

`
gcc client.c \
    -L/Users/suhaibknight/Code/dotnet-interop/NativeC \
    -lmyfunc \
    -Wl,-rpath,/Users/suhaibknight/Code/dotnet-interop/NativeC \
    -o client
`

Now we can port the executable binary anywhere and run the program.

If we compiled the client without the __rpath__, the executable will failed to load the dynamic library.
We can circumnavigate the situation by telling the os where to look for the shared library by specifying the
path in **DYLD_LIBRARY_PATH**

`
export DYLD_LIBRARY_PATH=/Users/Code/dotnet-interop/NativeC:$DYLD_LIBRARY_PATH
`

2. Static Linking
