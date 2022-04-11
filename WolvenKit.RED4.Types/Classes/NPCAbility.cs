using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCAbility : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("abilityName")] 
		public CString AbilityName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
