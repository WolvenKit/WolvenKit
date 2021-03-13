using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFuncCallEntry : ISerializable
	{
		[Ordinal(0)] [RED("callTime")] public EngineTime CallTime { get; set; }
		[Ordinal(1)] [RED("callId")] public CUInt32 CallId { get; set; }

		public gameFuncCallEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
