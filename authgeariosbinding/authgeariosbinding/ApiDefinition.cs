using System;
using Foundation;

namespace authgeariosbinding
{
	// @interface AuthgearSwift : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC13authgearswift13AuthgearSwift")]
	interface AuthgearSwift
	{
		// -(void)greet:(NSString * _Nonnull)name completion:(void (^ _Nonnull)(NSString * _Nonnull))completion;
		[Export("greet:completion:")]
		void Greet(string name, Action<NSString> completion);
	}
}
