using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarriedObjectData : IScriptable
	{
		[Ordinal(0)] [RED("instant")] public CBool Instant { get; set; }

		public CarriedObjectData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
