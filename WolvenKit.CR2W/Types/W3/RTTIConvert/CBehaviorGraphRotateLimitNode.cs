using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRotateLimitNode : CBehaviorGraphBaseNode
	{
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("axis")] 		public CEnum<EAxis> Axis { get; set;}

		[RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		public CBehaviorGraphRotateLimitNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRotateLimitNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}