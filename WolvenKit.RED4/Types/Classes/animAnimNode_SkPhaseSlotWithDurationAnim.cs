using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkPhaseSlotWithDurationAnim : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(32)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetPropertyValue<CResourceReference<animActionAnimDatabase>>();
			set => SetPropertyValue<CResourceReference<animActionAnimDatabase>>(value);
		}

		public animAnimNode_SkPhaseSlotWithDurationAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
