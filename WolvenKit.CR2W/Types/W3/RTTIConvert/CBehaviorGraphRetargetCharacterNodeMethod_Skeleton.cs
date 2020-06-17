using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRetargetCharacterNodeMethod_Skeleton : IBehaviorGraphRetargetCharacterNodeMethod
	{
		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("Bones with only scale", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_only_scale { get; set;}

		public CBehaviorGraphRetargetCharacterNodeMethod_Skeleton(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRetargetCharacterNodeMethod_Skeleton(cr2w);

	}
}