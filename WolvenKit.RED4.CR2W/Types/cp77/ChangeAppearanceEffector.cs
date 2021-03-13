using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeAppearanceEffector : gameEffector
	{
		[Ordinal(0)] [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)] [RED("resetAppearance")] public CBool ResetAppearance { get; set; }
		[Ordinal(2)] [RED("previousAppearance")] public CName PreviousAppearance { get; set; }
		[Ordinal(3)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public ChangeAppearanceEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
