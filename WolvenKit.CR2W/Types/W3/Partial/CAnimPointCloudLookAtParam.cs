using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
	{
		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("boneMSInv")] 		public CMatrix BoneMSInv { get; set;}

		[RED("boneTransMSInv")] 		public EngineQsTransform BoneTransMSInv { get; set;}

		[RED("directionLS")] 		public Vector DirectionLS { get; set;}

		[RED("pointsBS", 2,0)] 		public CArray<Vector> PointsBS { get; set;}

		[RED("pointToTriMapping", 2,0)] 		public CArray<CArray<CInt32>> PointToTriMapping { get; set;}

		[RED("refPose", 133,0)] 		public CArray<EngineQsTransform> RefPose { get; set;}

		public CAnimPointCloudLookAtParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimPointCloudLookAtParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}