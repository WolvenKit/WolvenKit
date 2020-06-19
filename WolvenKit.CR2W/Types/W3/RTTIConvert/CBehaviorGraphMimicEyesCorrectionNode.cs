using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicEyesCorrectionNode : CBehaviorGraphBaseMimicNode
	{
		[RED("trackEyeLeft_Left")] 		public CString TrackEyeLeft_Left { get; set;}

		[RED("trackEyeLeft_Right")] 		public CString TrackEyeLeft_Right { get; set;}

		[RED("trackEyeRight_Left")] 		public CString TrackEyeRight_Left { get; set;}

		[RED("trackEyeRight_Right")] 		public CString TrackEyeRight_Right { get; set;}

		public CBehaviorGraphMimicEyesCorrectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicEyesCorrectionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}