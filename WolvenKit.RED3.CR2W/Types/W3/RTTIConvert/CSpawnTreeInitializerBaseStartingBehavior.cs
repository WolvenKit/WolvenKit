using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerBaseStartingBehavior : ISpawnTreeInitializerAI
	{
		[Ordinal(1)] [RED("runBehaviorOnSpawn")] 		public CBool RunBehaviorOnSpawn { get; set;}

		[Ordinal(2)] [RED("runBehaviorOnActivation")] 		public CBool RunBehaviorOnActivation { get; set;}

		[Ordinal(3)] [RED("runBehaviorOnLoading")] 		public CBool RunBehaviorOnLoading { get; set;}

		[Ordinal(4)] [RED("actionPriority")] 		public CEnum<ETopLevelAIPriorities> ActionPriority { get; set;}

		public CSpawnTreeInitializerBaseStartingBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeInitializerBaseStartingBehavior(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}