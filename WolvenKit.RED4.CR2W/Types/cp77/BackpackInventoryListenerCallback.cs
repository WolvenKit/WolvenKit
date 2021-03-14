using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackInventoryListenerCallback : gameInventoryScriptCallback
	{
		private wCHandle<gameuiBackpackMainGameController> _backpackInstance;

		[Ordinal(1)] 
		[RED("backpackInstance")] 
		public wCHandle<gameuiBackpackMainGameController> BackpackInstance
		{
			get
			{
				if (_backpackInstance == null)
				{
					_backpackInstance = (wCHandle<gameuiBackpackMainGameController>) CR2WTypeManager.Create("whandle:gameuiBackpackMainGameController", "backpackInstance", cr2w, this);
				}
				return _backpackInstance;
			}
			set
			{
				if (_backpackInstance == value)
				{
					return;
				}
				_backpackInstance = value;
				PropertySet(this);
			}
		}

		public BackpackInventoryListenerCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
