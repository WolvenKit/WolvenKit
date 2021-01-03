using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetAttribute : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("attributeType")] public CEnum<gamedataStatType> AttributeType { get; set; }
		[Ordinal(1)]  [RED("statLevel")] public CFloat StatLevel { get; set; }

		public SetAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
