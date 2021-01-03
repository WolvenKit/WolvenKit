using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TraitDisplayData : BasePerkDisplayData
	{
		[Ordinal(0)]  [RED("type")] public CEnum<gamedataTraitType> Type { get; set; }

		public TraitDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
