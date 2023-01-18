using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetExclusiveFocusClueEntityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isSetExclusive")] 
		public CBool IsSetExclusive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetExclusiveFocusClueEntityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
