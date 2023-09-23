using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestStopFollowingTarget : ActionBool
	{
		[Ordinal(38)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestStopFollowingTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
