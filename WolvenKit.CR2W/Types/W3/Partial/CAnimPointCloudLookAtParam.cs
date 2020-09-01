using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
	{
		[Ordinal(1)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(2)] [RED("boneMSInv")] 		public CMatrix BoneMSInv { get; set;}

		[Ordinal(3)] [RED("boneTransMSInv")] 		public EngineQsTransform BoneTransMSInv { get; set;}

		[Ordinal(4)] [RED("directionLS")] 		public Vector DirectionLS { get; set;}

		[Ordinal(5)] [RED("pointsBS", 2,0)] 		public CArray<Vector> PointsBS { get; set;}

		[Ordinal(6)] [RED("pointToTriMapping", 2,0)] 		public CArray<CArray<CInt32>> PointToTriMapping { get; set;}

		[Ordinal(7)] [RED("refPose", 133,0)] 		public CArray<EngineQsTransform> RefPose { get; set;}

		public CAnimPointCloudLookAtParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimPointCloudLookAtParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}