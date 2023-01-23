using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetPossesion_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("playerPossesion")] 
		public CEnum<gamedataPlayerPossesion> PlayerPossesion
		{
			get => GetPropertyValue<CEnum<gamedataPlayerPossesion>>();
			set => SetPropertyValue<CEnum<gamedataPlayerPossesion>>(value);
		}

		public questSetPossesion_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
