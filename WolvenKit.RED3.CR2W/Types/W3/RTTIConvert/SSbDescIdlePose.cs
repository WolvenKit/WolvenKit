using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescIdlePose : CVariable
	{
		[Ordinal(1)] [RED("repoPoseId")] 		public CString RepoPoseId { get; set;}

		[Ordinal(2)] [RED("idleAnimName")] 		public CString IdleAnimName { get; set;}

		[Ordinal(3)] [RED("poseName")] 		public CString PoseName { get; set;}

		[Ordinal(4)] [RED("poseStatus")] 		public CString PoseStatus { get; set;}

		[Ordinal(5)] [RED("poseEmotionalState")] 		public CString PoseEmotionalState { get; set;}

		public SSbDescIdlePose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescIdlePose(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}