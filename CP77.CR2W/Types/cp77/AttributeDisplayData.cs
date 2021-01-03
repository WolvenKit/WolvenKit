using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AttributeDisplayData : IDisplayData
	{
		[Ordinal(0)]  [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(1)]  [RED("proficiencies")] public CArray<CHandle<ProficiencyDisplayData>> Proficiencies { get; set; }

		public AttributeDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
