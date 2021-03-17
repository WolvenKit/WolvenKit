using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeSpawnCompletedEvent : redEvent
	{
		private wCHandle<gameObject> _spawnedObject;

		[Ordinal(0)] 
		[RED("spawnedObject")] 
		public wCHandle<gameObject> SpawnedObject
		{
			get => GetProperty(ref _spawnedObject);
			set => SetProperty(ref _spawnedObject, value);
		}

		public gameNetrunnerPrototypeSpawnCompletedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
