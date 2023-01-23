using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRewindableSectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnRewindableSectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
