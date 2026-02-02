# Interoperability  

Interop (short for Interoperability) is the ability of different systems or languages to exchange information and work together. In the .NET world, it specifically refers to the mechanisms that allow "Managed Code" (code running safely inside the .NET Runtime) to talk to "Unmanaged Code" (code running directly on the hardware, like C or C++).

Under the .NET Interop umbrella, you generally find three main categories:

1. P/Invoke (Platform Invocation):

It allows you to call specific functions exported from a dynamic shared library (like our .dylib or a Windows .dll).

Best for: Calling C APIs (like operating system functions or libraries like Raylib).

2. COM Interop (Component Object Model):

A standard primarily used on Windows to let objects interact across different languages. If you've ever automated Excel from C#, you used COM Interop.

Best for: interacting with OLE/ActiveX controls or Windows shell extensions.

3. C++/CLI (Common Language Infrastructure):

A hybrid language. You write C++ code that can compile into .NET bytecode. It acts as a "glue" layer, understanding both managed C# objects and native C++ classes simultaneously.

Best for: Wrapping complex C++ class libraries where P/Invoke would be too messy.



## How to Build

This project uses [NUKE](https://nuke.build/) for its build system. You can build the project using the provided scripts in the root directory.

### Prerequisites
* **.NET SDK** (Ensure you have the version matching the project requirements)
* **C++ Build Tools** (Required for the native dependencies)

### Quick Start
To build the entire project (including restoring packages and compiling native dependencies), run the **Compile** target:

**Windows:**
```powershell
.\build.cmd Compile

**Linux:**
```
./build.sh Compile
