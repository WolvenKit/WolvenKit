using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHumanAICombatStorage : CBaseAICombatStorage
	{
		[RED("parryCount")] 		public CInt32 ParryCount { get; set;}

		[RED("activeStyle")] 		public CEnum<EBehaviorGraph> ActiveStyle { get; set;}

		[RED("preferedStyle")] 		public CEnum<EBehaviorGraph> PreferedStyle { get; set;}

		[RED("leaveCurrentStyle")] 		public CBool LeaveCurrentStyle { get; set;}

		[RED("processingItems")] 		public CBool ProcessingItems { get; set;}

		[RED("processingRequiresIdle")] 		public CBool ProcessingRequiresIdle { get; set;}

		[RED("mutlipleProjectiles", 2,0)] 		public CArray<CHandle<W3AdvancedProjectile>> MutlipleProjectiles { get; set;}

		[RED("currProjectile")] 		public CHandle<W3AdvancedProjectile> CurrProjectile { get; set;}

		[RED("protectedByQuen")] 		public CBool ProtectedByQuen { get; set;}

		[RED("followerAttackCooldown")] 		public CFloat FollowerAttackCooldown { get; set;}

		[RED("followerKeepDistanceToPlayer")] 		public CBool FollowerKeepDistanceToPlayer { get; set;}

		[RED("isAFollower")] 		public CBool IsAFollower { get; set;}

		public CHumanAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHumanAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}