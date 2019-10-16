using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IRESProject
{
    public class MyEntry: Entry
    {
        public MyEntry()
        {
            
        }
    }

    //public class VideoPlayer : View, IVideoPlayerController
    //{
    //    // Source property
    //    public static readonly BindableProperty SourceProperty =
    //        BindableProperty.Create(nameof(Source), typeof(VideoSource), typeof(VideoPlayer), null);

    //    [TypeConverter(typeof(VideoSourceConverter))]
    //    public VideoSource Source
    //    {
    //        set { SetValue(SourceProperty, value); }
    //        get { return (VideoSource)GetValue(SourceProperty); }
    //    }

    //    // AutoPlay property
    //    public static readonly BindableProperty AutoPlayProperty =
    //        BindableProperty.Create(nameof(AutoPlay), typeof(bool), typeof(VideoPlayer), true);

    //    public bool AutoPlay
    //    {
    //        set { SetValue(AutoPlayProperty, value); }
    //        get { return (bool)GetValue(AutoPlayProperty); }
    //    }
    //}
}
