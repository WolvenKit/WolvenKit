using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimSkeletalDangleConstraint : IAnimDangleConstraint
	{
		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("dispSkeleton")] 		public CBool DispSkeleton { get; set;}

		[RED("dispBoneNames")] 		public CBool DispBoneNames { get; set;}

		[RED("dispBoneAxis")] 		public CBool DispBoneAxis { get; set;}

		public CAnimSkeletalDangleConstraint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimSkeletalDangleConstraint(cr2w);

	}
}