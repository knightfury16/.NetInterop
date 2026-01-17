clean:
	rm -rf bin

bs: 
	mkdir -p bin
	gcc client.c \
	-L/Users/suhaibknight/code/dotnet-interop/NativeC/bin \
	-lmyfunc \
	-Wl,-rpath,/Users/suhaibknight/code/dotnet-interop/NativeC/bin \
	-o bin/client_shared

bstatic:
	mkdir -p bin
	gcc \
	client.c \
	-L/Users/suhaibknight/code/dotnet-interop/NativeC/bin \
	-lmyfunc_static \
	-o bin/client_static

run_shared:
	bin/client_shared


run_static:
	bin/client_static
