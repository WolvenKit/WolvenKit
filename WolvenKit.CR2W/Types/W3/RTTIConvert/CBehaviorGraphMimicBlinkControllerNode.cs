using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicBlinkControllerNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("("trackEyeLeft_Down")] 		public CString TrackEyeLeft_Down { get; set;}

		[Ordinal(2)] [RED("("trackEyeRight_Down")] 		public CString TrackEyeRight_Down { get; set;}

		[Ordinal(3)] [RED("("variableNameLeft")] 		public CName VariableNameLeft { get; set;}

		[Ordinal(4)] [RED("("variableNameRight")] 		public CName VariableNameRight { get; set;}

		public CBehaviorGraphMimicBlinkControllerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicBlinkControllerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}