using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskRequiredItems : IBehTreeTask
	{
		[RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[RED("RightItemType")] 		public CName RightItemType { get; set;}

		[RED("chooseSilverIfPossible")] 		public CBool ChooseSilverIfPossible { get; set;}

		[RED("destroyProjectileOnDeactivate")] 		public CBool DestroyProjectileOnDeactivate { get; set;}

		[RED("combatDataStorage")] 		public CHandle<CHumanAICombatStorage> CombatDataStorage { get; set;}

		[RED("processLeftItem")] 		public CBool ProcessLeftItem { get; set;}

		[RED("processRightItem")] 		public CBool ProcessRightItem { get; set;}

		[RED("requiredItems")] 		public CBool RequiredItems { get; set;}

		[RED("takeBowArrow")] 		public CBool TakeBowArrow { get; set;}

		[RED("takeBolt")] 		public CBool TakeBolt { get; set;}

		[RED("projResourceName")] 		public CString ProjResourceName { get; set;}

		[RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[RED("bolt")] 		public CHandle<W3AdvancedProjectile> Bolt { get; set;}

		public CBehTreeTaskRequiredItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskRequiredItems(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}