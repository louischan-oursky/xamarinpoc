import Foundation

@objc
public class AuthgearSwift: NSObject {
    @objc
    public func greet(_ name: String, completion: (String) -> Void) {
        let message = "Hello, \(name)"
        completion(message)
    }
}
