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
			get => GetProperty(ref _spawnerReference);
			set => SetProperty(ref _spawnerReference, value);
		}

		public questSpawner_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
