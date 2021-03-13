using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSequenceTargetInfo : ISerializable
	{
		[Ordinal(0)] [RED("path")] public CArray<CUInt32> Path { get; set; }

		public inkanimSequenceTargetInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
