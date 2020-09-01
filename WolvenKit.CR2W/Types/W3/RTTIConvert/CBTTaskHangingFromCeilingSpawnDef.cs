using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHangingFromCeilingSpawnDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(0)] [RED("("availableOnBehVarName")] 		public CName AvailableOnBehVarName { get; set;}

		[Ordinal(0)] [RED("("availableOnBehVarValue")] 		public CFloat AvailableOnBehVarValue { get; set;}

		[Ordinal(0)] [RED("("spawnOnHit")] 		public CBool SpawnOnHit { get; set;}

		[Ordinal(0)] [RED("("spawnOnDistanceToHostile")] 		public CFloat SpawnOnDistanceToHostile { get; set;}

		[Ordinal(0)] [RED("("spawnOnGameplayEventName")] 		public CName SpawnOnGameplayEventName { get; set;}

		[Ordinal(0)] [RED("("spawnOnAnimEventName")] 		public CName SpawnOnAnimEventName { get; set;}

		[Ordinal(0)] [RED("("traceToCeiling")] 		public CBool TraceToCeiling { get; set;}

		[Ordinal(0)] [RED("("verticalAdjustment")] 		public CBool VerticalAdjustment { get; set;}

		[Ordinal(0)] [RED("("horizontalAdjustment")] 		public CBool HorizontalAdjustment { get; set;}

		[Ordinal(0)] [RED("("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(0)] [RED("("manageCollision")] 		public CBool ManageCollision { get; set;}

		[Ordinal(0)] [RED("("reenableCollisionAfter")] 		public CFloat ReenableCollisionAfter { get; set;}

		[Ordinal(0)] [RED("("setCustomMovement")] 		public CBool SetCustomMovement { get; set;}

		[Ordinal(0)] [RED("("raiseEvent")] 		public CName RaiseEvent { get; set;}

		[Ordinal(0)] [RED("("timeOfInitialPosCorrection")] 		public CFloat TimeOfInitialPosCorrection { get; set;}

		[Ordinal(0)] [RED("("reuseInitialSpawnPosition")] 		public CBool ReuseInitialSpawnPosition { get; set;}

		public CBTTaskHangingFromCeilingSpawnDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHangingFromCeilingSpawnDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}