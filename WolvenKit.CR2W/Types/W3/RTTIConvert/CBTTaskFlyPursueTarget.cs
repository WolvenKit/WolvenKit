using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyPursueTarget : IBehTreeTask
	{
		[RED("useCustom")] 		public CBool UseCustom { get; set;}

		[RED("distanceFromTarget")] 		public CFloat DistanceFromTarget { get; set;}

		[RED("heightFromTarget")] 		public CFloat HeightFromTarget { get; set;}

		[RED("distanceTolerance")] 		public CFloat DistanceTolerance { get; set;}

		[RED("predictPositionTime")] 		public CFloat PredictPositionTime { get; set;}

		[RED("multiplyPredictTimeByDistance")] 		public CFloat MultiplyPredictTimeByDistance { get; set;}

		[RED("npcPosition")] 		public Vector NpcPosition { get; set;}

		[RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[RED("npcToTargetDistance2D")] 		public CFloat NpcToTargetDistance2D { get; set;}

		[RED("movePos")] 		public Vector MovePos { get; set;}

		[RED("cachedTime")] 		public CFloat CachedTime { get; set;}

		[RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		[RED("randomVectorFromTarget")] 		public Vector RandomVectorFromTarget { get; set;}

		[RED("flySpeed")] 		public CFloat FlySpeed { get; set;}

		public CBTTaskFlyPursueTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyPursueTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}