using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestFollowTarget : ActionEntityReference
	{
		[Ordinal(38)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestFollowTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
