using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimationPoseIK : CVariable
	{
		[RED("time")] 		public CFloat Time { get; set;}

		[RED("ids", 2,0)] 		public CArray<EnumWrapper<ETCrEffectorId>> Ids { get; set;}

		[RED("positionsMS", 2,0)] 		public CArray<Vector> PositionsMS { get; set;}

		[RED("rotationsMS", 2,0)] 		public CArray<EulerAngles> RotationsMS { get; set;}

		[RED("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		public VirtualAnimationPoseIK(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new VirtualAnimationPoseIK(cr2w);

	}
}