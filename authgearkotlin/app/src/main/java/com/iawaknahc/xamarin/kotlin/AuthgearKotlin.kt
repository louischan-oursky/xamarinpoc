package com.iawaknahc.xamarin.kotlin

class AuthgearKotlin {
    fun greet(name: String, completion: Completion<String>) {
        val message = "Hello, $name"
        completion.invoke(message, null)
    }
}