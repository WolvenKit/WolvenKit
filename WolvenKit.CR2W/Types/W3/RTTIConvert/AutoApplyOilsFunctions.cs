using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class AutoApplyOilsFunctions : CR4Player
	{
		[Ordinal(0)] [RED("enemyArray", 2,0)] 		public CArray<CHandle<CActor>> EnemyArray { get; set;}

		[Ordinal(0)] [RED("equippedItems", 2,0)] 		public CArray<SItemUniqueId> EquippedItems { get; set;}

		[Ordinal(0)] [RED("nameIsTypeArray", 2,0)] 		public CArray<actorNameType> NameIsTypeArray { get; set;}

		[Ordinal(0)] [RED("blankItemId")] 		public SItemUniqueId BlankItemId { get; set;}

		[Ordinal(0)] [RED("oilAppliedForBoss")] 		public CString OilAppliedForBoss { get; set;}

		[Ordinal(0)] [RED("notificationStrings", 2,0)] 		public CArray<CString> NotificationStrings { get; set;}

		[Ordinal(0)] [RED("errorStrings", 2,0)] 		public CArray<CString> ErrorStrings { get; set;}

		[Ordinal(0)] [RED("warningStrings", 2,0)] 		public CArray<CString> WarningStrings { get; set;}

		[Ordinal(0)] [RED("steelOilApplied")] 		public CBool SteelOilApplied { get; set;}

		[Ordinal(0)] [RED("silverOilApplied")] 		public CBool SilverOilApplied { get; set;}

		[Ordinal(0)] [RED("displayNotifications")] 		public CBool DisplayNotifications { get; set;}

		public AutoApplyOilsFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new AutoApplyOilsFunctions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}