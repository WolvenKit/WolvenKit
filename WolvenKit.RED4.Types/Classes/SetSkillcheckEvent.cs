using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetSkillcheckEvent : redEvent
	{
		private CHandle<BaseSkillCheckContainer> _skillcheckContainer;

		[Ordinal(0)] 
		[RED("skillcheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillcheckContainer
		{
			get => GetProperty(ref _skillcheckContainer);
			set => SetProperty(ref _skillcheckContainer, value);
		}
	}
}
