using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformDictionaryTransformEntry : CVariable
	{
		[Ordinal(0)] [RED("transform")] public Transform Transform { get; set; }
		[Ordinal(1)] [RED("usage")] public CUInt32 Usage { get; set; }
		[Ordinal(2)] [RED("id")] public CUInt16 Id { get; set; }

		public gameSmartObjectTransformDictionaryTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
