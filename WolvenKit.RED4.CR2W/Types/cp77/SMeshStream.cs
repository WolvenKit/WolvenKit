using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshStream : CVariable
	{
		[Ordinal(0)] [RED("data")] public serializationDeferredDataBuffer Data { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<EMeshStreamType> Type { get; set; }

		public SMeshStream(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
