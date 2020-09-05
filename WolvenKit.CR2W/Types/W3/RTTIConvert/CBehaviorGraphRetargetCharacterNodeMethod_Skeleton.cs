using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRetargetCharacterNodeMethod_Skeleton : IBehaviorGraphRetargetCharacterNodeMethod
	{
		[Ordinal(1)] [RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[Ordinal(2)] [RED("Bones with only scale", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_only_scale { get; set;}

		public CBehaviorGraphRetargetCharacterNodeMethod_Skeleton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRetargetCharacterNodeMethod_Skeleton(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}