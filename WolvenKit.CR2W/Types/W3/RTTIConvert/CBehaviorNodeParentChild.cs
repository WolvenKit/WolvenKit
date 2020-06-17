using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorNodeParentChild : CBehaviorGraphBaseNode
	{
		[RED("parentBoneName")] 		public CString ParentBoneName { get; set;}

		[RED("childBoneName")] 		public CString ChildBoneName { get; set;}

		[RED("offset")] 		public Vector Offset { get; set;}

		[RED("changeOnlyTranslation")] 		public CBool ChangeOnlyTranslation { get; set;}

		public CBehaviorNodeParentChild(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorNodeParentChild(cr2w);

	}
}