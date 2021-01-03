using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OnSquadmateDied : redEvent
	{
		[Ordinal(0)]  [RED("killer")] public wCHandle<entEntity> Killer { get; set; }
		[Ordinal(1)]  [RED("squad")] public CName Squad { get; set; }
		[Ordinal(2)]  [RED("squadmate")] public wCHandle<entEntity> Squadmate { get; set; }

		public OnSquadmateDied(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
