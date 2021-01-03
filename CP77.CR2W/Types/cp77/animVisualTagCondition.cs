using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animVisualTagCondition : animIStaticCondition
	{
		[Ordinal(0)]  [RED("visualTag")] public CName VisualTag { get; set; }

		public animVisualTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
