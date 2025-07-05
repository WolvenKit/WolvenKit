using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReactionPresetHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("reactionPreset")] 
		public CString ReactionPreset
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ReactionPresetHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
