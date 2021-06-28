using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHumanAICombatStorage : CBaseAICombatStorage
	{
		[Ordinal(1)] [RED("parryCount")] 		public CInt32 ParryCount { get; set;}

		[Ordinal(2)] [RED("activeStyle")] 		public CEnum<EBehaviorGraph> ActiveStyle { get; set;}

		[Ordinal(3)] [RED("preferedStyle")] 		public CEnum<EBehaviorGraph> PreferedStyle { get; set;}

		[Ordinal(4)] [RED("leaveCurrentStyle")] 		public CBool LeaveCurrentStyle { get; set;}

		[Ordinal(5)] [RED("processingItems")] 		public CBool ProcessingItems { get; set;}

		[Ordinal(6)] [RED("processingRequiresIdle")] 		public CBool ProcessingRequiresIdle { get; set;}

		[Ordinal(7)] [RED("mutlipleProjectiles", 2,0)] 		public CArray<CHandle<W3AdvancedProjectile>> MutlipleProjectiles { get; set;}

		[Ordinal(8)] [RED("currProjectile")] 		public CHandle<W3AdvancedProjectile> CurrProjectile { get; set;}

		[Ordinal(9)] [RED("protectedByQuen")] 		public CBool ProtectedByQuen { get; set;}

		[Ordinal(10)] [RED("followerAttackCooldown")] 		public CFloat FollowerAttackCooldown { get; set;}

		[Ordinal(11)] [RED("followerKeepDistanceToPlayer")] 		public CBool FollowerKeepDistanceToPlayer { get; set;}

		[Ordinal(12)] [RED("isAFollower")] 		public CBool IsAFollower { get; set;}

		public CHumanAICombatStorage(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}