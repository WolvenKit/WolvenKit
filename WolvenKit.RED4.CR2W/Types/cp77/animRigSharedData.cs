using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigSharedData : CResource
	{
		[Ordinal(1)] [RED("parts")] public CArray<animRigPart> Parts { get; set; }
		[Ordinal(2)] [RED("ikSetups")] public CArray<CHandle<animIRigIkSetup>> IkSetups { get; set; }

		public animRigSharedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
