using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperDocItemBoughtCallback : gameInventoryScriptCallback
	{
		private CHandle<RipperDocGameController> _eventTarget;

		[Ordinal(1)] 
		[RED("eventTarget")] 
		public CHandle<RipperDocGameController> EventTarget
		{
			get
			{
				if (_eventTarget == null)
				{
					_eventTarget = (CHandle<RipperDocGameController>) CR2WTypeManager.Create("handle:RipperDocGameController", "eventTarget", cr2w, this);
				}
				return _eventTarget;
			}
			set
			{
				if (_eventTarget == value)
				{
					return;
				}
				_eventTarget = value;
				PropertySet(this);
			}
		}

		public RipperDocItemBoughtCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
