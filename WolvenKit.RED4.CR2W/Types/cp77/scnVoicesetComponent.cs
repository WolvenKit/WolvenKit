using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVoicesetComponent : gameComponent
	{
		private CName _combatVoSettingsName;

		[Ordinal(4)] 
		[RED("combatVoSettingsName")] 
		public CName CombatVoSettingsName
		{
			get
			{
				if (_combatVoSettingsName == null)
				{
					_combatVoSettingsName = (CName) CR2WTypeManager.Create("CName", "combatVoSettingsName", cr2w, this);
				}
				return _combatVoSettingsName;
			}
			set
			{
				if (_combatVoSettingsName == value)
				{
					return;
				}
				_combatVoSettingsName = value;
				PropertySet(this);
			}
		}

		public scnVoicesetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
