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
			get
			{
				if (_playerPossesion == null)
				{
					_playerPossesion = (CEnum<gamedataPlayerPossesion>) CR2WTypeManager.Create("gamedataPlayerPossesion", "playerPossesion", cr2w, this);
				}
				return _playerPossesion;
			}
			set
			{
				if (_playerPossesion == value)
				{
					return;
				}
				_playerPossesion = value;
				PropertySet(this);
			}
		}

		public questSetPossesion_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
