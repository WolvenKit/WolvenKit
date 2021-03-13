using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("totalDuration")] public CFloat TotalDuration { get; set; }

		public TemporalPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
