using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIBaseMonsterDefaults : CAIDefaults
	{
		[Ordinal(1)] [RED("spawnTree")] 		public CHandle<CAIMonsterSpawn> SpawnTree { get; set;}

		[Ordinal(2)] [RED("keepDistance")] 		public CHandle<CAIKeepDistanceTree> KeepDistance { get; set;}

		[Ordinal(3)] [RED("tauntTree")] 		public CHandle<CAIMonsterTaunt> TauntTree { get; set;}

		[Ordinal(4)] [RED("axiiTree")] 		public CHandle<CAIMonsterAxii> AxiiTree { get; set;}

		[Ordinal(5)] [RED("idleDecoratorTree")] 		public CHandle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

		[Ordinal(6)] [RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[Ordinal(7)] [RED("ignoreReachability")] 		public CBool IgnoreReachability { get; set;}

		[Ordinal(8)] [RED("allowPursueDistance")] 		public CFloat AllowPursueDistance { get; set;}

		[Ordinal(9)] [RED("canSwim")] 		public CBool CanSwim { get; set;}

		[Ordinal(10)] [RED("canBury")] 		public CBool CanBury { get; set;}

		[Ordinal(11)] [RED("canKeepDistance")] 		public CBool CanKeepDistance { get; set;}

		public CAIBaseMonsterDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIBaseMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}