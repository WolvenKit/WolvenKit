using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleEventReceiverSpawn : IParticleEvent
	{
		private CEnum<EParticleEventSpawnObject> _spawnObject;

		[Ordinal(4)] 
		[RED("spawnObject")] 
		public CEnum<EParticleEventSpawnObject> SpawnObject
		{
			get => GetProperty(ref _spawnObject);
			set => SetProperty(ref _spawnObject, value);
		}

		public CParticleEventReceiverSpawn(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
