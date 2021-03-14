using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargebarStatsListener : gameScriptStatsListener
	{
		private wCHandle<ChargebarController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<ChargebarController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<ChargebarController>) CR2WTypeManager.Create("whandle:ChargebarController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		public ChargebarStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
