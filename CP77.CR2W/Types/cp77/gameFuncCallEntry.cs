using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameFuncCallEntry : ISerializable
	{
		[Ordinal(0)]  [RED("callId")] public CUInt32 CallId { get; set; }
		[Ordinal(1)]  [RED("callTime")] public EngineTime CallTime { get; set; }

		public gameFuncCallEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
