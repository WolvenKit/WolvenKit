using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrenadeAnimFeatureChangeEvent : redEvent
	{
		[Ordinal(0)] [RED("newState")] public CInt32 NewState { get; set; }

		public GrenadeAnimFeatureChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
