using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstanceId : CVariable
	{
		[Ordinal(0)] [RED("effectId")] public scnEffectId EffectId { get; set; }
		[Ordinal(1)] [RED("id")] public CUInt32 Id { get; set; }

		public scnEffectInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
