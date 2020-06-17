using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyPursueTargetDef : IBehTreeTaskDefinition
	{
		[RED("useCustom")] 		public CBool UseCustom { get; set;}

		[RED("distanceFromTarget")] 		public CFloat DistanceFromTarget { get; set;}

		[RED("heightFromTarget")] 		public CFloat HeightFromTarget { get; set;}

		[RED("distanceTolerance")] 		public CFloat DistanceTolerance { get; set;}

		[RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		[RED("predictPositionTime")] 		public CFloat PredictPositionTime { get; set;}

		public CBTTaskFlyPursueTargetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFlyPursueTargetDef(cr2w);

	}
}