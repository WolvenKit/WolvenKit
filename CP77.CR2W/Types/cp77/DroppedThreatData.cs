using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DroppedThreatData : CVariable
	{
		[Ordinal(0)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)]  [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(2)]  [RED("timeStamp")] public CFloat TimeStamp { get; set; }

		public DroppedThreatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
