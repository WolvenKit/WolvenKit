using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimationPoseFK : CVariable
	{
		[Ordinal(1)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(2)] [RED("controlPoints")] 		public Vector ControlPoints { get; set;}

		[Ordinal(3)] [RED("indices", 2,0)] 		public CArray<CInt32> Indices { get; set;}

		[Ordinal(4)] [RED("transforms", 133,0)] 		public CArray<EngineQsTransform> Transforms { get; set;}

		public VirtualAnimationPoseFK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VirtualAnimationPoseFK(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}