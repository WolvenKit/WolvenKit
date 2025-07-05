using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerCoverStatusChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<gamePlayerCoverDirection> Direction
		{
			get => GetPropertyValue<CEnum<gamePlayerCoverDirection>>();
			set => SetPropertyValue<CEnum<gamePlayerCoverDirection>>(value);
		}

		[Ordinal(1)] 
		[RED("fullyBehindCover")] 
		public CBool FullyBehindCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamePlayerCoverStatusChangedEvent()
		{
			Direction = Enums.gamePlayerCoverDirection.None;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
