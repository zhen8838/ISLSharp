# !/bin/bash
export CPATH="$(xcrun --show-sdk-path)/usr/include"
cd isl
make interface/extract_interface 
interface/extract_interface --language=csharp -I. -Iinclude ./all.h > ../ISLSharp/Interop.cs