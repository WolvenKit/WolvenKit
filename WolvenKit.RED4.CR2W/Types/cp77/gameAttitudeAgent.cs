using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgent : gameComponent
	{
		[Ordinal(4)] [RED("baseAttitudeGroup")] public CName BaseAttitudeGroup { get; set; }

		public gameAttitudeAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
