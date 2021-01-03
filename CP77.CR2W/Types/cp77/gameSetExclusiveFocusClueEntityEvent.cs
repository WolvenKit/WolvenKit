using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSetExclusiveFocusClueEntityEvent : redEvent
	{
		[Ordinal(0)]  [RED("isSetExclusive")] public CBool IsSetExclusive { get; set; }

		public gameSetExclusiveFocusClueEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
