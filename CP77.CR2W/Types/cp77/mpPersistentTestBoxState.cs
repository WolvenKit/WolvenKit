using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class mpPersistentTestBoxState : netIEntityState
	{
		[Ordinal(2)] [RED("isOn")] public CBool IsOn { get; set; }
		[Ordinal(3)] [RED("weakPersistentEntity")] public wCHandle<mpPersistentTestBox> WeakPersistentEntity { get; set; }
		[Ordinal(4)] [RED("weakPersistentEntityComponent")] public wCHandle<entIComponent> WeakPersistentEntityComponent { get; set; }
		[Ordinal(5)] [RED("weakDynamicEntity")] public wCHandle<gameObject> WeakDynamicEntity { get; set; }
		[Ordinal(6)] [RED("weakDynamicEntityComponent")] public wCHandle<entIComponent> WeakDynamicEntityComponent { get; set; }

		public mpPersistentTestBoxState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
