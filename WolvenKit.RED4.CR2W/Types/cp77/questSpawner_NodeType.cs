using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawner_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _spawnerReference;

		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get
			{
				if (_spawnerReference == null)
				{
					_spawnerReference = (NodeRef) CR2WTypeManager.Create("NodeRef", "spawnerReference", cr2w, this);
				}
				return _spawnerReference;
			}
			set
			{
				if (_spawnerReference == value)
				{
					return;
				}
				_spawnerReference = value;
				PropertySet(this);
			}
		}

		public questSpawner_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
