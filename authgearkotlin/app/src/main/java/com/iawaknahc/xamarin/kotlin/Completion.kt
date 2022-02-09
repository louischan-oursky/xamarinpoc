package com.iawaknahc.xamarin.kotlin

interface Completion<R> {
    fun invoke(result: R?, error: Throwable?)
}