using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Computer : Terminal
	{
		[Ordinal(0)]  [RED("bannerUpdateActive")] public CBool BannerUpdateActive { get; set; }
		[Ordinal(1)]  [RED("bannerUpdateID")] public gameDelayID BannerUpdateID { get; set; }
		[Ordinal(2)]  [RED("currentAnimationState")] public CEnum<EComputerAnimationState> CurrentAnimationState { get; set; }
		[Ordinal(3)]  [RED("playerControlData")] public PlayerControlDeviceData PlayerControlData { get; set; }
		[Ordinal(4)]  [RED("transformX")] public CHandle<entIPlacedComponent> TransformX { get; set; }
		[Ordinal(5)]  [RED("transformY")] public CHandle<entIPlacedComponent> TransformY { get; set; }

		public Computer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
