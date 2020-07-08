# procedural-text-adventure
Repository for a highly emergent procedurally generated sandbox fantasy text adventure RPG

## How to build (linux and similar)

Make sure you have CMake and Make installed

- Make and enter a directory `build`
- Run `cmake` in that directory, with the directory that contains `CMakeLists.txt` as argument
- Run `make` in that directory, without arguments.

	mkdir build
	cd build
	cmake ..
	make

You now have an executable file `phetag` in the `build` directory
