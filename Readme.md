# install isl 

```sh
git submodule update --init --recursive                                                                                   
cd isl
git apply ../patch # for clang
./autogen.sh
mkdir build
# export CFLAGS="-I/Users/lisa/miniforge3/envs/ci/include" # use conda install gmp
# export CXXFLAGS="-g"
# export LDFLAGS="-L/Users/lisa/miniforge3/envs/ci/lib -Wl,-rpath,/Users/lisa/miniforge3/envs/ci/lib" # gmp.dylib
# export DYLD_LIBRARY_PATH="${DYLD_LIBRARY_PATH}:/Users/lisa/miniforge3/envs/ci/lib"  
./configure --prefix=`pwd`/build --with-gmp-prefix=/Users/lisa/miniforge3/envs/ci --with-clang-prefix=/Users/lisa/Documents/llvm-project/build/install # the custom gmp/llvm install path
export CPATH="$(xcrun --show-sdk-path)/usr/include" # for macos
make
```

# add csharp binding

```sh
cd isl
# apply another patch
export CPATH="$(xcrun --show-sdk-path)/usr/include"
interface/extract_interface --language=csharp -I. -Iinclude ./all.h > ../ISLSharp/Interop.cs
```