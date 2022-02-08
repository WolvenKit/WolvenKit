using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EngineeringContainer : BaseSkillCheckContainer
	{
		[Ordinal(3)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
			set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
		}
	}
}
