using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace SwipeToRefresh
{
	public class OverscrollListView : ListView, AbsListView.IOnScrollListener
	{
		public event Action<int> OverScrolled;
		public event Action OverScrollCanceled;

		public OverscrollListView (Context context) :
			base (context)
		{
			Initialize ();
		}

		public OverscrollListView (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public OverscrollListView (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			SetOnScrollListener (this);
		}

		protected override bool OverScrollBy (int deltaX, int deltaY, int scrollX, int scrollY, int scrollRangeX, int scrollRangeY, int maxOverScrollX, int maxOverScrollY, bool isTouchEvent)
		{
			if (OverScrolled != null)
				OverScrolled (deltaY);
			return base.OverScrollBy (deltaX, deltaY, scrollX, scrollY, scrollRangeX, scrollRangeY, maxOverScrollX, maxOverScrollY, isTouchEvent);
		}

		public void OnScroll (AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
		{
			if (OverScrollCanceled != null)
				OverScrollCanceled ();
		}

		public void OnScrollStateChanged (AbsListView view, ScrollState scrollState)
		{
			if (OverScrollCanceled != null
			    && (scrollState == ScrollState.Idle || scrollState == ScrollState.Fling))
				OverScrollCanceled ();
		}
	}
}

