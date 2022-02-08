.PHONY: clean
clean:
	rm -rf ./build/

.PHONY: iphonesimulator
iphonesimulator:
	xcodebuild -sdk iphonesimulator -project authgearswift.xcodeproj -configuration Release

.PHONY: iphoneos
iphoneos:
	xcodebuild -sdk iphoneos -project authgearswift.xcodeproj -configuration Release

.PHONY: sharpie
sharpie:
	sharpie bind \
		--sdk iphoneos \
		--output ./build/sharpie \
		--namespace authgeariosbinding \
		--scope ./build/Release-iphonesimulator/authgearswift.framework/Headers/ \
		./build/Release-iphonesimulator/authgearswift.framework/Headers/authgearswift-Swift.h
