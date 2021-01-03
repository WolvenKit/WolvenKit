using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestBuyAttribute : redEvent
	{
		[Ordinal(0)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }

		public RequestBuyAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
