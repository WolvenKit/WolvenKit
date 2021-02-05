using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Computer : Terminal
	{
		[Ordinal(87)]  [RED("bannerUpdateActive")] public CBool BannerUpdateActive { get; set; }
		[Ordinal(88)]  [RED("bannerUpdateID")] public gameDelayID BannerUpdateID { get; set; }
		[Ordinal(89)]  [RED("transformX")] public CHandle<entIPlacedComponent> TransformX { get; set; }
		[Ordinal(90)]  [RED("transformY")] public CHandle<entIPlacedComponent> TransformY { get; set; }
		[Ordinal(91)]  [RED("playerControlData")] public PlayerControlDeviceData PlayerControlData { get; set; }
		[Ordinal(92)]  [RED("currentAnimationState")] public CEnum<EComputerAnimationState> CurrentAnimationState { get; set; }

		public Computer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
