using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entIPlacedComponent : entIComponent
	{
		[Ordinal(3)] [RED("localTransform")] public WorldTransform LocalTransform { get; set; }
		[Ordinal(4)] [RED("parentTransform")] public CHandle<entITransformBinding> ParentTransform { get; set; }

		public entIPlacedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
