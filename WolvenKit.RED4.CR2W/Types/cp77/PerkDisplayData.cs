using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayData : BasePerkDisplayData
	{
		[Ordinal(10)] [RED("area")] public CEnum<gamedataPerkArea> Area { get; set; }
		[Ordinal(11)] [RED("type")] public CEnum<gamedataPerkType> Type { get; set; }

		public PerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
