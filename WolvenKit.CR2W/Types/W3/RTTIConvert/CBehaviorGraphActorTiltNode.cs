using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphActorTiltNode : CBehaviorGraphPivotRotationNode
	{
		[RED("scaleFactor")] 		public CFloat ScaleFactor { get; set;}

		[RED("scaleAxis")] 		public CEnum<EAxis> ScaleAxis { get; set;}

		[RED("leftThighBone")] 		public CString LeftThighBone { get; set;}

		[RED("leftShinBone")] 		public CString LeftShinBone { get; set;}

		[RED("rightThighBone")] 		public CString RightThighBone { get; set;}

		[RED("rightShinBone")] 		public CString RightShinBone { get; set;}

		[RED("leftThighWeight")] 		public CFloat LeftThighWeight { get; set;}

		[RED("leftShinWeight")] 		public CFloat LeftShinWeight { get; set;}

		[RED("rightThighWeight")] 		public CFloat RightThighWeight { get; set;}

		[RED("rightShinWeight")] 		public CFloat RightShinWeight { get; set;}

		public CBehaviorGraphActorTiltNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphActorTiltNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}