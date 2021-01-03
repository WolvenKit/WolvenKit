using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePSDeviceChangedEvent : redEvent
	{
		[Ordinal(0)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)]  [RED("persistentID")] public gamePersistentID PersistentID { get; set; }

		public gamePSDeviceChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
