using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShouldBeScaredOnOverlay : IBehTreeTask
	{
		[RED("infantInHand")] 		public CBool InfantInHand { get; set;}

		[RED("catOnLap")] 		public CBool CatOnLap { get; set;}

		[RED("jobTreeType")] 		public CEnum<EJobTreeType> JobTreeType { get; set;}

		public CBTTaskShouldBeScaredOnOverlay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskShouldBeScaredOnOverlay(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}