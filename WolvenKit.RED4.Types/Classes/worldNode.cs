using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNode : ISerializable
	{
		[Ordinal(2)] 
		[RED("isVisibleInGame")] 
		public CBool IsVisibleInGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
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
