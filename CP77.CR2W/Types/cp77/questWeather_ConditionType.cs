using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questWeather_ConditionType : questISystemConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)]  [RED("weather")] public CName Weather { get; set; }

		public questWeather_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
