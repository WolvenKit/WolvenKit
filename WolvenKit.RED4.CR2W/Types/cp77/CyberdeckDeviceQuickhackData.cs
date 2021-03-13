using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckDeviceQuickhackData : CVariable
	{
		[Ordinal(0)] [RED("UIIcon")] public wCHandle<gamedataUIIcon_Record> UIIcon { get; set; }
		[Ordinal(1)] [RED("ObjectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }

		public CyberdeckDeviceQuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
