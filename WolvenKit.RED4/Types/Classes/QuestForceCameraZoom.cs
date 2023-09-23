using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestForceCameraZoom : ActionBool
	{
		[Ordinal(38)] 
		[RED("useWorkspot")] 
		public CBool UseWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestForceCameraZoom()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
