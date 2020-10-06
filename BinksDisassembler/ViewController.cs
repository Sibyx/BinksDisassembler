﻿using System;

using AppKit;
using BinksDisassembler.Disassembler;
using ELFSharp.ELF;
using Foundation;

namespace BinksDisassembler
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        
        public override void ViewDidDisappear()
        {
            base.ViewDidDisappear();
            NSApplication.SharedApplication.Terminate(this);
        }

        partial void LoadButtonClick(Foundation.NSObject sender)
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            dlg.AllowedFileTypes = new[] { "elf" };
            
            if (dlg.RunModal () == 1) {
                var path = dlg.Urls[0].Path;
                var elf = ELFReader.Load(path);
                var disassemblyFile = new OpenRiscExecutable(elf);
            }
        }
    }
}