using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIBaseMonsterDefaults : CAIDefaults
	{
		[RED("spawnTree")] 		public CHandle<CAIMonsterSpawn> SpawnTree { get; set;}

		[RED("keepDistance")] 		public CHandle<CAIKeepDistanceTree> KeepDistance { get; set;}

		[RED("tauntTree")] 		public CHandle<CAIMonsterTaunt> TauntTree { get; set;}

		[RED("axiiTree")] 		public CHandle<CAIMonsterAxii> AxiiTree { get; set;}

		[RED("idleDecoratorTree")] 		public CHandle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

		[RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[RED("ignoreReachability")] 		public CBool IgnoreReachability { get; set;}

		[RED("allowPursueDistance")] 		public CFloat AllowPursueDistance { get; set;}

		[RED("canSwim")] 		public CBool CanSwim { get; set;}

		[RED("canBury")] 		public CBool CanBury { get; set;}

		[RED("canKeepDistance")] 		public CBool CanKeepDistance { get; set;}

		public CAIBaseMonsterDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIBaseMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}