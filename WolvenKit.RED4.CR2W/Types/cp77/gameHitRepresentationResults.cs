using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResults : CVariable
	{
		[Ordinal(0)] [RED("sults")] public CArray<gameHitRepresentationResult> Sults { get; set; }

		public gameHitRepresentationResults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
