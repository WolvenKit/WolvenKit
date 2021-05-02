using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskRequiredItems : IBehTreeTask
	{
		[Ordinal(1)] [RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[Ordinal(2)] [RED("RightItemType")] 		public CName RightItemType { get; set;}

		[Ordinal(3)] [RED("chooseSilverIfPossible")] 		public CBool ChooseSilverIfPossible { get; set;}

		[Ordinal(4)] [RED("destroyProjectileOnDeactivate")] 		public CBool DestroyProjectileOnDeactivate { get; set;}

		[Ordinal(5)] [RED("combatDataStorage")] 		public CHandle<CHumanAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(6)] [RED("processLeftItem")] 		public CBool ProcessLeftItem { get; set;}

		[Ordinal(7)] [RED("processRightItem")] 		public CBool ProcessRightItem { get; set;}

		[Ordinal(8)] [RED("requiredItems")] 		public CBool RequiredItems { get; set;}

		[Ordinal(9)] [RED("takeBowArrow")] 		public CBool TakeBowArrow { get; set;}

		[Ordinal(10)] [RED("takeBolt")] 		public CBool TakeBolt { get; set;}

		[Ordinal(11)] [RED("projResourceName")] 		public CString ProjResourceName { get; set;}

		[Ordinal(12)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(13)] [RED("bolt")] 		public CHandle<W3AdvancedProjectile> Bolt { get; set;}

		public CBehTreeTaskRequiredItems(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}