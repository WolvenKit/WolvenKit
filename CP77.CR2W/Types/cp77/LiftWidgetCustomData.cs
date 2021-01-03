using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LiftWidgetCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("movementState")] public CEnum<gamePlatformMovementState> MovementState { get; set; }

		public LiftWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
