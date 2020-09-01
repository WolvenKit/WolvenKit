using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTAvoidObstacles : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("avoidObstaclesImportance")] 		public CFloat AvoidObstaclesImportance { get; set;}

		[Ordinal(2)] [RED("timeToChooseNextObstacle")] 		public CFloat TimeToChooseNextObstacle { get; set;}

		[Ordinal(3)] [RED("maxDistanceToObstacle")] 		public CFloat MaxDistanceToObstacle { get; set;}

		[Ordinal(4)] [RED("furthestImpactTime")] 		public CFloat FurthestImpactTime { get; set;}

		[Ordinal(5)] [RED("overrideValues")] 		public CBool OverrideValues { get; set;}

		[Ordinal(6)] [RED("modifyRotation")] 		public CBool ModifyRotation { get; set;}

		[Ordinal(7)] [RED("modifyHeading")] 		public CBool ModifyHeading { get; set;}

		[Ordinal(8)] [RED("modifySpeed")] 		public CBool ModifySpeed { get; set;}

		public CMoveSTAvoidObstacles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTAvoidObstacles(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}