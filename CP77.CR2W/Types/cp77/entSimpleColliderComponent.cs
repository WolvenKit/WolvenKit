using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSimpleColliderComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("colliders")] public CArray<CHandle<physicsICollider>> Colliders { get; set; }
		[Ordinal(1)]  [RED("filter")] public CHandle<physicsFilterData> Filter { get; set; }
		[Ordinal(2)]  [RED("compiledBuffer")] public DataBuffer CompiledBuffer { get; set; }

		public entSimpleColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
