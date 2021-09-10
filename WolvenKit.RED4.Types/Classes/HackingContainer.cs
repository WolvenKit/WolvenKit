using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HackingContainer : BaseSkillCheckContainer
	{
		[Ordinal(3)] 
		[RED("hackingCheck")] 
		public CHandle<HackingSkillCheck> HackingCheck
		{
			get => GetPropertyValue<CHandle<HackingSkillCheck>>();
			set => SetPropertyValue<CHandle<HackingSkillCheck>>(value);
		}
	}
}
