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
			get
			{
				if (_spawnObject == null)
				{
					_spawnObject = (CEnum<EParticleEventSpawnObject>) CR2WTypeManager.Create("EParticleEventSpawnObject", "spawnObject", cr2w, this);
				}
				return _spawnObject;
			}
			set
			{
				if (_spawnObject == value)
				{
					return;
				}
				_spawnObject = value;
				PropertySet(this);
			}
		}

		public CParticleEventReceiverSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
