using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectsCompiledResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("animationDatabase")] public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase { get; set; }
		[Ordinal(1)]  [RED("compiledNodesData")] public CHandle<gameCompiledNodes> CompiledNodesData { get; set; }
		[Ordinal(2)]  [RED("localBoundingBox")] public Box LocalBoundingBox { get; set; }
		[Ordinal(3)]  [RED("propertyDictionary")] public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary { get; set; }
		[Ordinal(4)]  [RED("soMembership")] public CHandle<gameSmartObjectMembership> SoMembership { get; set; }
		[Ordinal(5)]  [RED("transformDictionary")] public CHandle<gameSmartObjectTransformDictionary> TransformDictionary { get; set; }
		[Ordinal(6)]  [RED("transformSequenceDictionary")] public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary { get; set; }

		public gameSmartObjectsCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
