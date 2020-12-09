using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphActorTiltNode : CBehaviorGraphPivotRotationNode
	{
		[Ordinal(1)] [RED("scaleFactor")] 		public CFloat ScaleFactor { get; set;}

		[Ordinal(2)] [RED("scaleAxis")] 		public CEnum<EAxis> ScaleAxis { get; set;}

		[Ordinal(3)] [RED("leftThighBone")] 		public CString LeftThighBone { get; set;}

		[Ordinal(4)] [RED("leftShinBone")] 		public CString LeftShinBone { get; set;}

		[Ordinal(5)] [RED("rightThighBone")] 		public CString RightThighBone { get; set;}

		[Ordinal(6)] [RED("rightShinBone")] 		public CString RightShinBone { get; set;}

		[Ordinal(7)] [RED("leftThighWeight")] 		public CFloat LeftThighWeight { get; set;}

		[Ordinal(8)] [RED("leftShinWeight")] 		public CFloat LeftShinWeight { get; set;}

		[Ordinal(9)] [RED("rightThighWeight")] 		public CFloat RightThighWeight { get; set;}

		[Ordinal(10)] [RED("rightShinWeight")] 		public CFloat RightShinWeight { get; set;}

		public CBehaviorGraphActorTiltNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphActorTiltNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}