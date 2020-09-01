using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterPursueTarget : IBehTreeTask
	{
		[Ordinal(0)] [RED("useCustom")] 		public CBool UseCustom { get; set;}

		[Ordinal(0)] [RED("distanceFromTarget")] 		public CFloat DistanceFromTarget { get; set;}

		[Ordinal(0)] [RED("heightFromTarget")] 		public CFloat HeightFromTarget { get; set;}

		[Ordinal(0)] [RED("distanceTolerance")] 		public CFloat DistanceTolerance { get; set;}

		[Ordinal(0)] [RED("npcPosition")] 		public Vector NpcPosition { get; set;}

		[Ordinal(0)] [RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[Ordinal(0)] [RED("npcToTargetDistance2D")] 		public CFloat NpcToTargetDistance2D { get; set;}

		[Ordinal(0)] [RED("movePos")] 		public Vector MovePos { get; set;}

		[Ordinal(0)] [RED("cachedTime")] 		public CFloat CachedTime { get; set;}

		[Ordinal(0)] [RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		[Ordinal(0)] [RED("flySpeed")] 		public CFloat FlySpeed { get; set;}

		public CBTTaskUnderwaterPursueTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterPursueTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}