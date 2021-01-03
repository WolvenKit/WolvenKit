using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SMeshTopology : CVariable
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("metadata")] public DataBuffer Metadata { get; set; }

		public SMeshTopology(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
