using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStatePelvisTransitionNode : CBehaviorGraphStateTransitionBlendNode
	{
		[RED("pelvisBoneName")] 		public CString PelvisBoneName { get; set;}

		[RED("pelvisDirectionFwdLS")] 		public CEnum<EAxis> PelvisDirectionFwdLS { get; set;}

		[RED("usePelvisBlendMethod")] 		public CBool UsePelvisBlendMethod { get; set;}

		public CBehaviorGraphStatePelvisTransitionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStatePelvisTransitionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}