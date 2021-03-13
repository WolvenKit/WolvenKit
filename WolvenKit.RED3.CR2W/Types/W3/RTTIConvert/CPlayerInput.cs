using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayerInput : CObject
	{
		[Ordinal(1)] [RED("actionLocks", 2,0)] 		public CArray<CArray<SInputActionLock>> ActionLocks { get; set;}

		[Ordinal(2)] [RED("totalCameraPresetChange")] 		public CFloat TotalCameraPresetChange { get; set;}

		[Ordinal(3)] [RED("potAction")] 		public SInputAction PotAction { get; set;}

		[Ordinal(4)] [RED("potPress")] 		public CBool PotPress { get; set;}

		[Ordinal(5)] [RED("debugBlockSourceName")] 		public CName DebugBlockSourceName { get; set;}

		[Ordinal(6)] [RED("holdFastMenuInvoked")] 		public CBool HoldFastMenuInvoked { get; set;}

		[Ordinal(7)] [RED("potionUpperHeld")] 		public CBool PotionUpperHeld { get; set;}

		[Ordinal(8)] [RED("potionLowerHeld")] 		public CBool PotionLowerHeld { get; set;}

		[Ordinal(9)] [RED("potionModeHold")] 		public CBool PotionModeHold { get; set;}

		[Ordinal(10)] [RED("pressTimestamp")] 		public CFloat PressTimestamp { get; set;}

		[Ordinal(11)] [RED("DOUBLE_TAP_WINDOW")] 		public CFloat DOUBLE_TAP_WINDOW { get; set;}

		[Ordinal(12)] [RED("processedSwordHold")] 		public CBool ProcessedSwordHold { get; set;}

		[Ordinal(13)] [RED("lastMovementDoubleTapName")] 		public CName LastMovementDoubleTapName { get; set;}

		public CPlayerInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayerInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}