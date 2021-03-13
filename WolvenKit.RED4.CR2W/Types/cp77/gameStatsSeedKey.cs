using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsSeedKey : CVariable
	{
		[Ordinal(0)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(2)] [RED("seed")] public CUInt32 Seed { get; set; }

		public gameStatsSeedKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
