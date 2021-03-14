using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairWeaponStatsListener : gameScriptStatsListener
	{
		private wCHandle<BaseTechCrosshairController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<BaseTechCrosshairController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<BaseTechCrosshairController>) CR2WTypeManager.Create("whandle:BaseTechCrosshairController", "controller", cr2w, this);
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

		public CrosshairWeaponStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
