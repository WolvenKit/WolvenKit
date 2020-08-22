using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayerInput : CObject
	{
		[RED("actionLocks", 2,0)] 		public CArray<CArray<SInputActionLock>> ActionLocks { get; set;}

		[RED("totalCameraPresetChange")] 		public CFloat TotalCameraPresetChange { get; set;}

		[RED("potAction")] 		public SInputAction PotAction { get; set;}

		[RED("potPress")] 		public CBool PotPress { get; set;}

		[RED("debugBlockSourceName")] 		public CName DebugBlockSourceName { get; set;}

		[RED("holdFastMenuInvoked")] 		public CBool HoldFastMenuInvoked { get; set;}

		[RED("potionUpperHeld")] 		public CBool PotionUpperHeld { get; set;}

		[RED("potionLowerHeld")] 		public CBool PotionLowerHeld { get; set;}

		[RED("potionModeHold")] 		public CBool PotionModeHold { get; set;}

		[RED("pressTimestamp")] 		public CFloat PressTimestamp { get; set;}

		[RED("DOUBLE_TAP_WINDOW")] 		public CFloat DOUBLE_TAP_WINDOW { get; set;}

		[RED("processedSwordHold")] 		public CBool ProcessedSwordHold { get; set;}

		[RED("lastMovementDoubleTapName")] 		public CName LastMovementDoubleTapName { get; set;}

		public CPlayerInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayerInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}