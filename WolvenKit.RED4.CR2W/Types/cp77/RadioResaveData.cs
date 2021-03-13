using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioResaveData : CVariable
	{
		[Ordinal(0)] [RED("mediaResaveData")] public MediaResaveData MediaResaveData { get; set; }
		[Ordinal(1)] [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }

		public RadioResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
