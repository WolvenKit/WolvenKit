using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePSDeviceChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("persistentID")] public gamePersistentID PersistentID { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }

		public gamePSDeviceChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
