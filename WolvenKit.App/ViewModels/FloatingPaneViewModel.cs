﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.App.ViewModels;
public abstract class FloatingPaneViewModel : PaneViewModel
{
    protected FloatingPaneViewModel(string header, string contentId) : base(header, contentId)
    {
    }

    public virtual double Width { get; set; } = 1200;
    public virtual double Height { get; set; } = 800;

}