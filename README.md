# Swipe Down to Refresh

This is a [Xamarin.Android](http://xamarin.com/android) implementation of the swipe-down-to-refresh pattern that has been introduced by Google with their 2013 Gmail app update.

![swipe down to refresh screenshot](https://blog.neteril.org/wp-content/uploads/swipe-to-refresh/device-swipe-down-refresh.png)

The idea of the pattern is that when a ListView is positioned at the beginning, starting an overscroll will, in addition to the normal edge effect, change the ActionBar to display an action message and an horizontal centered progress bar defining when the movement results in a refresh of the content.

Blog post explaining some key parts of this implementation: [blog.neteril.org/blog/2013/06/07/xamarin-android-swipe-down-to-refresh/](https://blog.neteril.org/blog/2013/06/07/xamarin-android-swipe-down-to-refresh/)

Pattern in action:

<div style="text-align:center; margin:auto"><video width="289" height="480" preload="none" controls="" poster="https://blog.neteril.org/wp-content/uploads/swipe-to-refresh/screencast-pattern.jpg" style="text-align:center; margin:auto"><source src="https://blog.neteril.org/wp-content/uploads/swipe-to-refresh/screencast-pattern.m4v" type="video/mp4; codecs=&quot;avc1.42E01E, mp4a.40.2&quot;"></video></div>
