using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossHealthStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<BossHealthBarGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public wCHandle<BossHealthBarGameController> Healthbar
		{
			get
			{
				if (_healthbar == null)
				{
					_healthbar = (wCHandle<BossHealthBarGameController>) CR2WTypeManager.Create("whandle:BossHealthBarGameController", "healthbar", cr2w, this);
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

		public BossHealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
