﻿using System;
using UIKit;
namespace Comet.iOS
{
    public class HUITapGesture : UITapGestureRecognizer
    {
        public HUITapGesture(TapGesture gesture) : base (()=> gesture.Invoke())
        {
            gesture.NativeGesture = this;
        }
        //TODO SetGesture Tate
        public override UIGestureRecognizerState State { get => base.State; set => base.State = value; }
       
    }
}
