using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimGraphDebugState : ISerializable
	{
		[Ordinal(0)] [RED("nodes")] public CArray<animAnimNodeDebugState> Nodes { get; set; }

		public animAnimGraphDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
