using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("questFactName")] public CName QuestFactName { get; set; }

		public HoloDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
