using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestChangeSecuritySystemAttitudeGroup : redEvent
	{
		[Ordinal(0)] 
		[RED("newAttitudeGroup")] 
		public TweakDBID NewAttitudeGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public QuestChangeSecuritySystemAttitudeGroup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
