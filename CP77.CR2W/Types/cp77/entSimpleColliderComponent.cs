using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entSimpleColliderComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("colliders")] public CArray<CHandle<physicsICollider>> Colliders { get; set; }
		[Ordinal(1)]  [RED("compiledBuffer")] public DataBuffer CompiledBuffer { get; set; }
		[Ordinal(2)]  [RED("filter")] public CHandle<physicsFilterData> Filter { get; set; }

		public entSimpleColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
