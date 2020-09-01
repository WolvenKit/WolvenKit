using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorNodeParentChild : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("parentBoneName")] 		public CString ParentBoneName { get; set;}

		[Ordinal(0)] [RED("childBoneName")] 		public CString ChildBoneName { get; set;}

		[Ordinal(0)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(0)] [RED("changeOnlyTranslation")] 		public CBool ChangeOnlyTranslation { get; set;}

		public CBehaviorNodeParentChild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorNodeParentChild(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}