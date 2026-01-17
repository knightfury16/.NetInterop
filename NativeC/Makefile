bin/myfunc: myfunc.c
	mkdir -p bin
	gcc myfunc.c -o bin/myfunc

clean:
	rm -rf bin

brun:
	gcc myfunc.c -o bin/myfunc
	bin/myfunc

bs: 
	mkdir -p bin
	gcc myfunc.c \
	-shared \
	-install_name @rpath/libmyfunc.dylib \
	-o bin/libmyfunc.dylib 


bstatic:
	mkdir -p bin
	gcc \
	-c myfunc.c \
	-o bin/libmyfunc_static.o && \
	ar rcs bin/libmyfunc_static.a bin/libmyfunc_static.o

run:
	bin/myfunc

