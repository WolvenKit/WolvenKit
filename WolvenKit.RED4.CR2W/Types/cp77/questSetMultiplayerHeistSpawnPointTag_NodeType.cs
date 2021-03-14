using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetMultiplayerHeistSpawnPointTag_NodeType : questIMultiplayerHeistNodeType
	{
		private CName _spawnPointTag;

		[Ordinal(0)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get
			{
				if (_spawnPointTag == null)
				{
					_spawnPointTag = (CName) CR2WTypeManager.Create("CName", "spawnPointTag", cr2w, this);
				}
				return _spawnPointTag;
			}
			set
			{
				if (_spawnPointTag == value)
				{
					return;
				}
				_spawnPointTag = value;
				PropertySet(this);
			}
		}

		public questSetMultiplayerHeistSpawnPointTag_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
