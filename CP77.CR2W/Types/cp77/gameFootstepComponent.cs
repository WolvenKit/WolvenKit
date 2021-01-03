using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameFootstepComponent : entIComponent
	{
		[Ordinal(0)]  [RED("leftFootSlot")] public CName LeftFootSlot { get; set; }
		[Ordinal(1)]  [RED("rightFootSlot")] public CName RightFootSlot { get; set; }
		[Ordinal(2)]  [RED("tweakDBID")] public TweakDBID TweakDBID { get; set; }

		public gameFootstepComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
