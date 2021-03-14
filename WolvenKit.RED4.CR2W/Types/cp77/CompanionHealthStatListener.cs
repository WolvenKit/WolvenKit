using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompanionHealthStatListener : gameScriptStatPoolsListener
	{
		private CHandle<CompanionHealthBarGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public CHandle<CompanionHealthBarGameController> Healthbar
		{
			get
			{
				if (_healthbar == null)
				{
					_healthbar = (CHandle<CompanionHealthBarGameController>) CR2WTypeManager.Create("handle:CompanionHealthBarGameController", "healthbar", cr2w, this);
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

		public CompanionHealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
