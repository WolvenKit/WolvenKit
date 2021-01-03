using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class moveEnteredSplineEvent : redEvent
	{
		[Ordinal(0)]  [RED("useDoors")] public CBool UseDoors { get; set; }

		public moveEnteredSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
