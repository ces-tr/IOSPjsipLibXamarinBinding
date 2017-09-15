using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace IOSPjsipXamarinBinding
{


	// @interface IOSPjsipWrapper : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface IOSPjsipWrapper
	{
		// +(instancetype)iOSPjsipWrapperInstance;
		[Static]
		[Export("iOSPjsipWrapperInstance")]
		IOSPjsipWrapper IOSPjsipWrapperInstance();

		// -(void)configureEndpoint;
		[Export("configureEndpoint")]
		void ConfigureEndpoint();

		// -(void)addSIPAccountP:(id)configuration completionHandler:(void (^)(int *))handler;
		[Export("addSIPAccountP:completionHandler:")]
		unsafe void AddSIPAccountP(NSObject configuration, Action<int> handler);

		// -(void)makeVideoCall;
		[Export("makeVideoCall")]
		void MakeVideoCall();

		// -(void)makeCall;
		[Export("makeCall")]
		void MakeCall ();
	}

	// @interface SWAccountConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface SWAccountConfiguration
	{
		// @property (nonatomic, strong) NSString * displayName;
		[Export("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (nonatomic, strong) NSString * address;
		[Export("address", ArgumentSemantic.Strong)]
		string Address { get; set; }

		// @property (nonatomic, strong) NSString * domain;
		[Export("domain", ArgumentSemantic.Strong)]
		string Domain { get; set; }

		// @property (nonatomic, strong) NSString * proxy;
		[Export("proxy", ArgumentSemantic.Strong)]
		string Proxy { get; set; }

		// @property (nonatomic, strong) NSString * authScheme;
		[Export("authScheme", ArgumentSemantic.Strong)]
		string AuthScheme { get; set; }

		// @property (nonatomic, strong) NSString * authRealm;
		[Export("authRealm", ArgumentSemantic.Strong)]
		string AuthRealm { get; set; }

		// @property (nonatomic, strong) NSString * username;
		[Export("username", ArgumentSemantic.Strong)]
		string Username { get; set; }

		// @property (nonatomic, strong) NSString * password;
		[Export("password", ArgumentSemantic.Strong)]
		string Password { get; set; }

		// @property (nonatomic) BOOL registerOnAdd;
		[Export("registerOnAdd")]
		bool RegisterOnAdd { get; set; }

		// @property (nonatomic) BOOL publishEnabled;
		[Export("publishEnabled")]
		bool PublishEnabled { get; set; }

		// +(NSString *)addressFromUsername:(NSString *)username domain:(NSString *)domain;
		[Static]
		[Export("addressFromUsername:domain:")]
		string AddressFromUsername(string username, string domain);
	}



	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
}
