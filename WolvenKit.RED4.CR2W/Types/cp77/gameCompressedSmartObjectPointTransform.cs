using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompressedSmartObjectPointTransform : CVariable
	{
		[Ordinal(0)] [RED("transformId")] public CUInt16 TransformId { get; set; }

		public gameCompressedSmartObjectPointTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
