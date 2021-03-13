using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTime : CVariable
	{
		[Ordinal(0)] [RED("seconds")] public CInt32 Seconds { get; set; }

		public GameTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
