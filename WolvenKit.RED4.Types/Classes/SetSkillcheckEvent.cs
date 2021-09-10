using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetSkillcheckEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("skillcheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillcheckContainer
		{
			get => GetPropertyValue<CHandle<BaseSkillCheckContainer>>();
			set => SetPropertyValue<CHandle<BaseSkillCheckContainer>>(value);
		}
	}
}
