using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DoorReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)]  [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(1)]  [RED("wasImmediateChange")] public CBool WasImmediateChange { get; set; }

		public DoorReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
