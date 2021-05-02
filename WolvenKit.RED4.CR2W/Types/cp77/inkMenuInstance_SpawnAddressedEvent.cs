using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMenuInstance_SpawnAddressedEvent : inkMenuInstance_SpawnEvent
	{

		public inkMenuInstance_SpawnAddressedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
