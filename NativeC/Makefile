# Detect OS
ifeq ($(OS),Windows_NT)
	detected_os :=  Windows
else
	detected_os := $(shell uname -s)
endif

$(info [DEBUG] Immediate check: $(detected_os))

# Default Flags
CC = gcc
CFLAGS = -Wall -Wextra -I
LIB_NAME = libmyfunc
SRC = myfunc.c

# Default Linux Value

LIB_EXT = .so
LIB_FLAGS = -shared -fPIC
EXE_EXT =



# Windows OS specific override
ifeq ($(detected_os),Windows)
    LIB_EXT = .dll
    EXE_EXT = .exe
endif


# Macos OS specific override
ifeq ($(detected_os),Darwin)
    LIB_EXT = .dylib
    LIB_FLAGS = -shared -install_name @rpath/$(LIB_NAME)$(LIB_EXT)
endif


bin/$(LIB_NAME): $(SRC)
	mkdir -p bin
	$(CC) $(SRC) $(LIB_FLAGS) -o bin/$(LIB_NAME)$(LIB_EXT)

clean:
	rm -rf bin


# bstatic:
# 	mkdir -p bin
# 	gcc \
# 	-c myfunc.c \
# 	-o bin/libmyfunc_static.o && \
# 	ar rcs bin/libmyfunc_static.a bin/libmyfunc_static.o

run:
	bin/myfunc

