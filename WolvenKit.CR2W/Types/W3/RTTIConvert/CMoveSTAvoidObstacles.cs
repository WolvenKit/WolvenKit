using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTAvoidObstacles : IMoveSteeringTask
	{
		[RED("avoidObstaclesImportance")] 		public CFloat AvoidObstaclesImportance { get; set;}

		[RED("timeToChooseNextObstacle")] 		public CFloat TimeToChooseNextObstacle { get; set;}

		[RED("maxDistanceToObstacle")] 		public CFloat MaxDistanceToObstacle { get; set;}

		[RED("furthestImpactTime")] 		public CFloat FurthestImpactTime { get; set;}

		[RED("overrideValues")] 		public CBool OverrideValues { get; set;}

		[RED("modifyRotation")] 		public CBool ModifyRotation { get; set;}

		[RED("modifyHeading")] 		public CBool ModifyHeading { get; set;}

		[RED("modifySpeed")] 		public CBool ModifySpeed { get; set;}

		public CMoveSTAvoidObstacles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTAvoidObstacles(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}