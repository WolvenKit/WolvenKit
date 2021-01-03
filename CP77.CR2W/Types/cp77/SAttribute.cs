using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SAttribute : CVariable
	{
		[Ordinal(0)]  [RED("attributeName")] public CEnum<gamedataStatType> AttributeName { get; set; }
		[Ordinal(1)]  [RED("id")] public TweakDBID Id { get; set; }
		[Ordinal(2)]  [RED("value")] public CInt32 Value { get; set; }

		public SAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
