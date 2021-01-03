using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstanceId : CVariable
	{
		[Ordinal(0)]  [RED("effectId")] public scnEffectId EffectId { get; set; }
		[Ordinal(1)]  [RED("id")] public CUInt32 Id { get; set; }

		public scnEffectInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
