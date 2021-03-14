using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GodModeStatListener : gameScriptStatsListener
	{
		private CHandle<healthbarWidgetGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public CHandle<healthbarWidgetGameController> Healthbar
		{
			get
			{
				if (_healthbar == null)
				{
					_healthbar = (CHandle<healthbarWidgetGameController>) CR2WTypeManager.Create("handle:healthbarWidgetGameController", "healthbar", cr2w, this);
				}
				return _healthbar;
			}
			set
			{
				if (_healthbar == value)
				{
					return;
				}
				_healthbar = value;
				PropertySet(this);
			}
		}

		public GodModeStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
