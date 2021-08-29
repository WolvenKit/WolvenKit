using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCAbility : RedBaseClass
	{
		private CString _abilityName;

		[Ordinal(0)] 
		[RED("abilityName")] 
		public CString AbilityName
		{
			get => GetProperty(ref _abilityName);
			set => SetProperty(ref _abilityName, value);
		}
	}
}
