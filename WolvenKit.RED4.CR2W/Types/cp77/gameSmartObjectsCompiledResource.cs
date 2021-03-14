using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectsCompiledResource : resStreamedResource
	{
		[Ordinal(1)] [RED("animationDatabase")] public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase { get; set; }
		[Ordinal(2)] [RED("compiledNodesData")] public CHandle<gameCompiledNodes> CompiledNodesData { get; set; }
		[Ordinal(3)] [RED("transformDictionary")] public CHandle<gameSmartObjectTransformDictionary> TransformDictionary { get; set; }
		[Ordinal(4)] [RED("propertyDictionary")] public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary { get; set; }
		[Ordinal(5)] [RED("transformSequenceDictionary")] public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary { get; set; }
		[Ordinal(6)] [RED("soMembership")] public CHandle<gameSmartObjectMembership> SoMembership { get; set; }
		[Ordinal(7)] [RED("localBoundingBox")] public Box LocalBoundingBox { get; set; }

		public gameSmartObjectsCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
