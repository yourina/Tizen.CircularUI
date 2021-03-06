﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WearableUIGallery.TC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TCCircleScrollerBarColor : CirclePage
    {

        static Color[] _colors = new Color[] {
            Color.Blue,
            Color.Red,
            Color.Green,
            Color.Violet,
            Color.Pink,
            Color.SkyBlue,
            Color.GreenYellow,
            Color.White,
            Color.Silver,
            Color.Yellow
        };

        static int i = 0;

        public TCCircleScrollerBarColor()
        {
            InitializeComponent ();

            button.Clicked += (s, e) =>
            {
                if (i >= 10) i = 0;
                myscroller.BarColor = _colors[i++];
            };
        }
    }
}