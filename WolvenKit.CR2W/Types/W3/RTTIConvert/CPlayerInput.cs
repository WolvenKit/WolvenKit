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
		[Ordinal(0)] [RED("("actionLocks", 2,0)] 		public CArray<CArray<SInputActionLock>> ActionLocks { get; set;}

		[Ordinal(0)] [RED("("totalCameraPresetChange")] 		public CFloat TotalCameraPresetChange { get; set;}

		[Ordinal(0)] [RED("("potAction")] 		public SInputAction PotAction { get; set;}

		[Ordinal(0)] [RED("("potPress")] 		public CBool PotPress { get; set;}

		[Ordinal(0)] [RED("("debugBlockSourceName")] 		public CName DebugBlockSourceName { get; set;}

		[Ordinal(0)] [RED("("holdFastMenuInvoked")] 		public CBool HoldFastMenuInvoked { get; set;}

		[Ordinal(0)] [RED("("potionUpperHeld")] 		public CBool PotionUpperHeld { get; set;}

		[Ordinal(0)] [RED("("potionLowerHeld")] 		public CBool PotionLowerHeld { get; set;}

		[Ordinal(0)] [RED("("potionModeHold")] 		public CBool PotionModeHold { get; set;}

		[Ordinal(0)] [RED("("pressTimestamp")] 		public CFloat PressTimestamp { get; set;}

		[Ordinal(0)] [RED("("DOUBLE_TAP_WINDOW")] 		public CFloat DOUBLE_TAP_WINDOW { get; set;}

		[Ordinal(0)] [RED("("processedSwordHold")] 		public CBool ProcessedSwordHold { get; set;}

		[Ordinal(0)] [RED("("lastMovementDoubleTapName")] 		public CName LastMovementDoubleTapName { get; set;}

		public CPlayerInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayerInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}