using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetPossesion_NodeType : questISceneManagerNodeType
	{
		private CEnum<gamedataPlayerPossesion> _playerPossesion;

		[Ordinal(0)] 
		[RED("playerPossesion")] 
		public CEnum<gamedataPlayerPossesion> PlayerPossesion
		{
			get => GetProperty(ref _playerPossesion);
			set => SetProperty(ref _playerPossesion, value);
		}
	}
}
