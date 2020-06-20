using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescIdlePose : CVariable
	{
		[RED("repoPoseId")] 		public CString RepoPoseId { get; set;}

		[RED("idleAnimName")] 		public CString IdleAnimName { get; set;}

		[RED("poseName")] 		public CString PoseName { get; set;}

		[RED("poseStatus")] 		public CString PoseStatus { get; set;}

		[RED("poseEmotionalState")] 		public CString PoseEmotionalState { get; set;}

		public SSbDescIdlePose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescIdlePose(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}