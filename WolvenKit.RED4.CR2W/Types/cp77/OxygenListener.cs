using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenListener : gameScriptStatPoolsListener
	{
		private wCHandle<OxygenbarWidgetGameController> _oxygenBar;

		[Ordinal(0)] 
		[RED("oxygenBar")] 
		public wCHandle<OxygenbarWidgetGameController> OxygenBar
		{
			get
			{
				if (_oxygenBar == null)
				{
					_oxygenBar = (wCHandle<OxygenbarWidgetGameController>) CR2WTypeManager.Create("whandle:OxygenbarWidgetGameController", "oxygenBar", cr2w, this);
				}
				return _oxygenBar;
			}
			set
			{
				if (_oxygenBar == value)
				{
					return;
				}
				_oxygenBar = value;
				PropertySet(this);
			}
		}

		public OxygenListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
