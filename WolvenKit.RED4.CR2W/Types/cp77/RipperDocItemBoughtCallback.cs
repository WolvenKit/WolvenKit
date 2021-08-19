using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperDocItemBoughtCallback : gameInventoryScriptCallback
	{
		private wCHandle<RipperDocGameController> _eventTarget;

		[Ordinal(1)] 
		[RED("eventTarget")] 
		public wCHandle<RipperDocGameController> EventTarget
		{
			get => GetProperty(ref _eventTarget);
			set => SetProperty(ref _eventTarget, value);
		}

		public RipperDocItemBoughtCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
