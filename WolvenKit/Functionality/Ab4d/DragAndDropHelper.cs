// ----------------------------------------------------------------
// <copyright file="DragAndDropHelper.cs" company="AB4D d.o.o.">
//     Copyright (c) AB4D d.o.o.  All Rights Reserved
// </copyright>
// ----------------------------------------------------------------

using System;
using System.Linq;
using System.Windows;

namespace WolvenKit.Functionality.Ab4d
{
    public class FileDroppedEventArgs : EventArgs
    {
        public string FileName;

        public FileDroppedEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    public class DragAndDropHelper
    {
        private readonly string[] _allowedFileExtensions;

        public event EventHandler<FileDroppedEventArgs> FileDropped;

        // set usePreviewEvents to true for TextBox or some other controls that handle dropping by themselves
        public DragAndDropHelper(FrameworkElement controlToAddDragAndDrop, string allowedFileExtensions = null, bool usePreviewEvents = false)
        {
            if (string.IsNullOrEmpty(allowedFileExtensions) || allowedFileExtensions == "*" || allowedFileExtensions == ".*")
            {
                // no filter
                _allowedFileExtensions = null;
            }
            else
            {
                _allowedFileExtensions = allowedFileExtensions.Split(new[] { ';', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                              .Select(e => e.Trim())
                                                              .Select(e => e.StartsWith(".") ? e : '.' + e) // make sure that each extension has leading '.' because Path.GetExtension also gets such extension
                                                              .ToArray();
            }

            controlToAddDragAndDrop.AllowDrop = true;

            if (usePreviewEvents)
            {
                controlToAddDragAndDrop.PreviewDrop += pageToAddDragAndDrop_Drop;
                controlToAddDragAndDrop.PreviewDragOver += pageToAddDragAndDrop_DragOver;
            }
            else
            {
                controlToAddDragAndDrop.Drop += pageToAddDragAndDrop_Drop;
                controlToAddDragAndDrop.DragOver += pageToAddDragAndDrop_DragOver;

            }
        }

        public void pageToAddDragAndDrop_DragOver(object sender, DragEventArgs args)
        {
            args.Effects = DragDropEffects.None;

            if (args.Data.GetDataPresent("FileNameW"))
            {
                var dropData = args.Data.GetData("FileNameW");

                var dropFileNames = dropData as string[];
                if (dropFileNames != null && dropFileNames.Length > 0)
                {
                    var fileName = dropFileNames[0];
                    var fileExtension = System.IO.Path.GetExtension(fileName);

                    if (_allowedFileExtensions == null)
                    {
                        args.Effects = DragDropEffects.Move;
                    }
                    else
                    {
                        if (_allowedFileExtensions.Any(e => e.Equals(fileExtension, StringComparison.OrdinalIgnoreCase)))
                            args.Effects = DragDropEffects.Move;
                    }
                }
            }

            if (args.Effects != DragDropEffects.None)
                args.Handled = true;
        }

        public void pageToAddDragAndDrop_Drop(object sender, DragEventArgs args)
        {
            if (args.Data.GetDataPresent("FileNameW"))
            {
                var dropData = args.Data.GetData("FileNameW");

                var dropFileNames = dropData as string[];
                if (dropFileNames != null && dropFileNames.Length > 0)
                {
                    OnFileDropped(dropFileNames[0]);
                    args.Handled = true;
                }
            }
        }

        protected void OnFileDropped(string fileName)
        {
            if (FileDropped != null)
                FileDropped(this, new FileDroppedEventArgs(fileName));
        }
    }
}
