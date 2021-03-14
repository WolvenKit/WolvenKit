using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShowUIWarningEffector : gameEffector
	{
		[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)] [RED("primaryText")] public CString PrimaryText { get; set; }
		[Ordinal(2)] [RED("secondaryText")] public CString SecondaryText { get; set; }
		[Ordinal(3)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public ShowUIWarningEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
