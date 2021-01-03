using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariable : ISerializable
	{
		[Ordinal(0)]  [RED("id")] public CUInt16 Id { get; set; }
		[Ordinal(1)]  [RED("readableName")] public CName ReadableName { get; set; }

		public LibTreeDefTreeVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
