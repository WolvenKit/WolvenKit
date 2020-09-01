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
		[Ordinal(1)] [RED("enemyArray", 2,0)] 		public CArray<CHandle<CActor>> EnemyArray { get; set;}

		[Ordinal(2)] [RED("equippedItems", 2,0)] 		public CArray<SItemUniqueId> EquippedItems { get; set;}

		[Ordinal(3)] [RED("nameIsTypeArray", 2,0)] 		public CArray<actorNameType> NameIsTypeArray { get; set;}

		[Ordinal(4)] [RED("blankItemId")] 		public SItemUniqueId BlankItemId { get; set;}

		[Ordinal(5)] [RED("oilAppliedForBoss")] 		public CString OilAppliedForBoss { get; set;}

		[Ordinal(6)] [RED("notificationStrings", 2,0)] 		public CArray<CString> NotificationStrings { get; set;}

		[Ordinal(7)] [RED("errorStrings", 2,0)] 		public CArray<CString> ErrorStrings { get; set;}

		[Ordinal(8)] [RED("warningStrings", 2,0)] 		public CArray<CString> WarningStrings { get; set;}

		[Ordinal(9)] [RED("steelOilApplied")] 		public CBool SteelOilApplied { get; set;}

		[Ordinal(10)] [RED("silverOilApplied")] 		public CBool SilverOilApplied { get; set;}

		[Ordinal(11)] [RED("displayNotifications")] 		public CBool DisplayNotifications { get; set;}

		public AutoApplyOilsFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new AutoApplyOilsFunctions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}