using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNode : ISerializable
	{
		[Ordinal(0)] 
		[RED("isVisibleInGame")] 
		public CBool IsVisibleInGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isHostOnly")] 
		public CBool IsHostOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldNode()
		{
			IsVisibleInGame = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
