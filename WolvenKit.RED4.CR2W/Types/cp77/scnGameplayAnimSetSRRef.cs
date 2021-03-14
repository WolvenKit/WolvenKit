using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayAnimSetSRRef : CVariable
	{
		[Ordinal(0)] [RED("asyncAnimSet")] public raRef<animAnimSet> AsyncAnimSet { get; set; }

		public scnGameplayAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
