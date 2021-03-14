using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorNodeParentChild : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("parentBoneName")] 		public CString ParentBoneName { get; set;}

		[Ordinal(2)] [RED("childBoneName")] 		public CString ChildBoneName { get; set;}

		[Ordinal(3)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(4)] [RED("changeOnlyTranslation")] 		public CBool ChangeOnlyTranslation { get; set;}

		public CBehaviorNodeParentChild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorNodeParentChild(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}