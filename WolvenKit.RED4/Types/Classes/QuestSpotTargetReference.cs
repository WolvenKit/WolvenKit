using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestSpotTargetReference : ActionEntityReference
	{
		[Ordinal(38)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestSpotTargetReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
