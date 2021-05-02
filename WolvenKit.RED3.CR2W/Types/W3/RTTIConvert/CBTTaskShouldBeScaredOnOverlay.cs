using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShouldBeScaredOnOverlay : IBehTreeTask
	{
		[Ordinal(1)] [RED("infantInHand")] 		public CBool InfantInHand { get; set;}

		[Ordinal(2)] [RED("catOnLap")] 		public CBool CatOnLap { get; set;}

		[Ordinal(3)] [RED("jobTreeType")] 		public CEnum<EJobTreeType> JobTreeType { get; set;}

		public CBTTaskShouldBeScaredOnOverlay(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskShouldBeScaredOnOverlay(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}