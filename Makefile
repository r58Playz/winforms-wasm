STATICS_RELEASE=87d20f43-0820-47e0-8cf1-b4e0cd1a50aa
DOTNETFLAGS=--nodereuse:false -v n

statics:
	mkdir statics
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/SDL3.a -O statics/SDL3.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libgdiplus.a -O statics/gdiplus.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libcairo.a -O statics/libcairo.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libexpat.a -O statics/libexpat.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libffi.a -O statics/libffi.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libfontconfig.a -O statics/libfontconfig.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libfreetype.a -O statics/libfreetype.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libpixman-1.a -O statics/libpixman-1.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libpng16.a -O statics/libpng16.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libz.a -O statics/libz.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/libglib-2.0-dotnet.a -O statics/libglib-2.0.a
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/System.Drawing.Common.dll -O statics/System.Drawing.Common.dll
	wget https://github.com/r58Playz/FNA-WASM-Build/releases/download/$(STATICS_RELEASE)/dotnet.zip -O statics/dotnet.zip
	unzip -q -o statics/dotnet.zip -d statics/dotnet

emsdk:
	git clone https://github.com/emscripten-core/emsdk
	./emsdk/emsdk install 3.1.56
	./emsdk/emsdk activate 3.1.56
	python3 ./sanitizeemsdk.py "$(shell realpath ./emsdk/)"
	patch -p1 --directory emsdk/upstream/emscripten/ < emsdk.patch
	patch -p1 --directory emsdk/upstream/emscripten/ < emsdk.2.patch
	rm -rvf emsdk/upstream/emscripten/cache/*

dotnetclean:
	rm -rvf {bin,obj} || true
clean: dotnetclean
	rm -rvf statics || true

deps: statics emsdk

build: deps
	rm -r frontend/public/_framework bin/Release/net10.0/publish/wwwroot/_framework || true
#
	dotnet publish -c Release $(DOTNETFLAGS)
#
	cp -r bin/Release/net10.0/publish/wwwroot/_framework frontend/public/
	# emscripten sucks
	#sed -i 's/var offscreenCanvases \?= \?{};/var offscreenCanvases={};if(globalThis.window\&\&!window.TRANSFERRED_CANVAS){transferredCanvasNames=[".canvas"];window.TRANSFERRED_CANVAS=true;}/' frontend/public/_framework/dotnet.native.*.js
	# sdl3 sucks
	sed -i 's/FS.mkdir("\/tmp\/filedrop");//' frontend/public/_framework/dotnet.native.*.js
	# dotnet messed up
	sed -i 's/this.appendULeb(32768)/this.appendULeb(65535)/' frontend/public/_framework/dotnet.runtime.*.js

serve: build
	cd frontend && pnpm dev

publish: build
	cd frontend && pnpm build


.PHONY: clean build serve publish
