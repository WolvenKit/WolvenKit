using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMenuGameController : gameuiWidgetGameController
	{
		private wCHandle<inkMenuEventDispatcher> _baseEventDispatcher;

		[Ordinal(2)] 
		[RED("baseEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher
		{
			get
			{
				if (_baseEventDispatcher == null)
				{
					_baseEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "baseEventDispatcher", cr2w, this);
				}
				return _baseEventDispatcher;
			}
			set
			{
				if (_baseEventDispatcher == value)
				{
					return;
				}
				_baseEventDispatcher = value;
				PropertySet(this);
			}
		}

		public gameuiMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
