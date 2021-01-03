using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SMeshStream : CVariable
	{
		[Ordinal(0)]  [RED("data")] public serializationDeferredDataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<EMeshStreamType> Type { get; set; }

		public SMeshStream(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
