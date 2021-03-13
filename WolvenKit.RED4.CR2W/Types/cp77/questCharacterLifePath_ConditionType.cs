using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterLifePath_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("lifePathID")] public TweakDBID LifePathID { get; set; }

		public questCharacterLifePath_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
