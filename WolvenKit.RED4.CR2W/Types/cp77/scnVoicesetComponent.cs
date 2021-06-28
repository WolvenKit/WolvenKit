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
			get => GetProperty(ref _combatVoSettingsName);
			set => SetProperty(ref _combatVoSettingsName, value);
		}

		public scnVoicesetComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
