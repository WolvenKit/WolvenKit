using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicEyesCorrectionNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("trackEyeLeft_Left")] 		public CString TrackEyeLeft_Left { get; set;}

		[Ordinal(2)] [RED("trackEyeLeft_Right")] 		public CString TrackEyeLeft_Right { get; set;}

		[Ordinal(3)] [RED("trackEyeRight_Left")] 		public CString TrackEyeRight_Left { get; set;}

		[Ordinal(4)] [RED("trackEyeRight_Right")] 		public CString TrackEyeRight_Right { get; set;}

		public CBehaviorGraphMimicEyesCorrectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicEyesCorrectionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}