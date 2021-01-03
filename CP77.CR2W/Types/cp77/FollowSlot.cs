using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FollowSlot : IScriptable
	{
		[Ordinal(0)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)]  [RED("isAvailable")] public CBool IsAvailable { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("slotTransform")] public Transform SlotTransform { get; set; }

		public FollowSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
