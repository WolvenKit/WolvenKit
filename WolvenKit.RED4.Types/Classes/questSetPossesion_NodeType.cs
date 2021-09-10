using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetPossesion_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("playerPossesion")] 
		public CEnum<gamedataPlayerPossesion> PlayerPossesion
		{
			get => GetPropertyValue<CEnum<gamedataPlayerPossesion>>();
			set => SetPropertyValue<CEnum<gamedataPlayerPossesion>>(value);
		}
	}
}
