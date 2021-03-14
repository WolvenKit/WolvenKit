using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariable : ISerializable
	{
		[Ordinal(0)] [RED("id")] public CUInt16 Id { get; set; }
		[Ordinal(1)] [RED("readableName")] public CName ReadableName { get; set; }

		public LibTreeDefTreeVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
