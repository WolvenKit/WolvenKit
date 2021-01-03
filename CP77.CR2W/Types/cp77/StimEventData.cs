using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StimEventData : CVariable
	{
		[Ordinal(0)]  [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(1)]  [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }
		[Ordinal(2)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public StimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
