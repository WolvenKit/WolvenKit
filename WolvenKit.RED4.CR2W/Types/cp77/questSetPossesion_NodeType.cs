using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPossesion_NodeType : questISceneManagerNodeType
	{
		private CEnum<gamedataPlayerPossesion> _playerPossesion;

		[Ordinal(0)] 
		[RED("playerPossesion")] 
		public CEnum<gamedataPlayerPossesion> PlayerPossesion
		{
			get => GetProperty(ref _playerPossesion);
			set => SetProperty(ref _playerPossesion, value);
		}

		public questSetPossesion_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
