using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISyannaCompanionBehavior : IAIBaseAction
	{
		[Ordinal(1)] [RED("params")] 		public CHandle<CAISyannaCompanionBehaviorParams> Params { get; set;}

		[Ordinal(2)] [RED("useCustomSteering")] 		public CBool UseCustomSteering { get; set;}

		[Ordinal(3)] [RED("customSteeringGraph")] 		public CHandle<CMoveSteeringBehavior> CustomSteeringGraph { get; set;}

		public CAISyannaCompanionBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISyannaCompanionBehavior(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}