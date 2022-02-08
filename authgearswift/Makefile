.PHONY: clean
clean:
	rm -rf ./build/

.PHONY: iphonesimulator
iphonesimulator:
	xcodebuild -sdk iphonesimulator -project authgearswift.xcodeproj -configuration Release

.PHONY: iphoneos
iphoneos:
	xcodebuild -sdk iphoneos -project authgearswift.xcodeproj -configuration Release
