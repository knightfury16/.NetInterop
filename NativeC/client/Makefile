# Detect OS
ifeq ($(OS),Windows_NT)
	detected_os :=  Windows
else
	detected_os := $(shell uname -s)
endif


$(info [DEBUG] Immediate check: $(detected_os))

# Default Flags
CC = gcc
CFLAGS = -Wall
LIB_NAME = client_shared
LIB_DIR := $(abspath ../bin)
$(info [DEBUG] Immediate check: $(LIB_DIR))
SHARED_FLAGS := -L"$(LIB_DIR)" -lmyfunc

SRC = client.c

# Default Linux Value

LIB_EXT =
LIB_FLAGS = -shared -fPIC
EXE_EXT =



# Windows OS specific override
ifneq ($(detected_os),Windows)
    SHARED_FLAGS += -Wl,-rpath,"$(LIB_DIR)"
endif


# Macos OS specific override
ifeq ($(detected_os),Windows)
    LIB_EXT = .exe
	@copy "$(subst /,\,$(LIB_DIR))\libmyfunc.dll" "bin\" >nul
    # LIB_FLAGS = -shared -install_name @rpath/$(LIB_NAME)$(LIB_EXT)
endif

bs:
	mkdir -p bin
	$(CC) $(SRC) $(SHARED_FLAGS) -o bin/$(LIB_NAME)$(LIB_EXT)



# bstatic:
# 	mkdir -p bin
# 	gcc \
# 	client.c \
# 	-L/Users/suhaibknight/code/dotnet-interop/NativeC/bin \
# 	-lmyfunc_static \
# 	-o bin/client_static
#
#
run:
	bin/client_shared


# run_static:
# 	bin/client_static

clean:
	rm -rf bin
