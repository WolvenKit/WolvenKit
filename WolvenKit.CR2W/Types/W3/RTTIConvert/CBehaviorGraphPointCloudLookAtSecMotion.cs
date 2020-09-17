using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPointCloudLookAtSecMotion : CObject
	{
		[Ordinal(1)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(2)] [RED("masterBones", 2,0)] 		public CArray<CInt32> MasterBones { get; set;}

		[Ordinal(3)] [RED("masterBoneAxis")] 		public CEnum<EAxis> MasterBoneAxis { get; set;}

		[Ordinal(4)] [RED("maxMasterMotionAngleDeg")] 		public CFloat MaxMasterMotionAngleDeg { get; set;}

		[Ordinal(5)] [RED("defaultAnimation")] 		public CName DefaultAnimation { get; set;}

		public CBehaviorGraphPointCloudLookAtSecMotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPointCloudLookAtSecMotion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}