using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestCrystalDomeEvent : redEvent
	{
		[Ordinal(0)]  [RED("removeQuestControl")] public CBool RemoveQuestControl { get; set; }
		[Ordinal(1)]  [RED("toggle")] public CBool Toggle { get; set; }

		public VehicleQuestCrystalDomeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
