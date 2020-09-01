using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAHDAutoLootConfig : CObject
	{
		[Ordinal(0)] [RED("UserSettings")] 		public CHandle<CInGameConfigWrapper> UserSettings { get; set;}

		[Ordinal(0)] [RED("features")] 		public CHandle<CAHDAutoLootFeatureManager> Features { get; set;}

		[Ordinal(0)] [RED("filters")] 		public CHandle<CAHDAutoLootFilters> Filters { get; set;}

		[Ordinal(0)] [RED("actions")] 		public CHandle<CAHDAutoLootActions> Actions { get; set;}

		[Ordinal(0)] [RED("modEnabled")] 		public CBool ModEnabled { get; set;}

		[Ordinal(0)] [RED("useFilters")] 		public CBool UseFilters { get; set;}

		[Ordinal(0)] [RED("useNoAccidentalStealing")] 		public CBool UseNoAccidentalStealing { get; set;}

		[Ordinal(0)] [RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[Ordinal(0)] [RED("useIsHerb")] 		public CBool UseIsHerb { get; set;}

		[Ordinal(0)] [RED("useIsCorpse")] 		public CBool UseIsCorpse { get; set;}

		[Ordinal(0)] [RED("useIsArmor")] 		public CBool UseIsArmor { get; set;}

		[Ordinal(0)] [RED("useIsWeapon")] 		public CBool UseIsWeapon { get; set;}

		[Ordinal(0)] [RED("useIsUpgrade")] 		public CBool UseIsUpgrade { get; set;}

		[Ordinal(0)] [RED("useIsFood")] 		public CBool UseIsFood { get; set;}

		[Ordinal(0)] [RED("useIsFormula")] 		public CBool UseIsFormula { get; set;}

		[Ordinal(0)] [RED("useIsReadable")] 		public CBool UseIsReadable { get; set;}

		[Ordinal(0)] [RED("useIsIngredient")] 		public CBool UseIsIngredient { get; set;}

		[Ordinal(0)] [RED("useIsMoney")] 		public CBool UseIsMoney { get; set;}

		[Ordinal(0)] [RED("useIsNotJunk")] 		public CBool UseIsNotJunk { get; set;}

		[Ordinal(0)] [RED("useQuantity")] 		public CBool UseQuantity { get; set;}

		[Ordinal(0)] [RED("useWeight")] 		public CBool UseWeight { get; set;}

		[Ordinal(0)] [RED("useValue")] 		public CBool UseValue { get; set;}

		[Ordinal(0)] [RED("useItemQuality")] 		public CBool UseItemQuality { get; set;}

		[Ordinal(0)] [RED("enableTrueAutoLoot")] 		public CBool EnableTrueAutoLoot { get; set;}

		[Ordinal(0)] [RED("enableTrueAutoLootOnStart")] 		public CBool EnableTrueAutoLootOnStart { get; set;}

		[Ordinal(0)] [RED("filterLogic")] 		public CInt32 FilterLogic { get; set;}

		[Ordinal(0)] [RED("quantityLogic")] 		public CInt32 QuantityLogic { get; set;}

		[Ordinal(0)] [RED("weightLogic")] 		public CInt32 WeightLogic { get; set;}

		[Ordinal(0)] [RED("valueAmount")] 		public CInt32 ValueAmount { get; set;}

		[Ordinal(0)] [RED("valueLogic")] 		public CInt32 ValueLogic { get; set;}

		[Ordinal(0)] [RED("qualityLogic")] 		public CInt32 QualityLogic { get; set;}

		[Ordinal(0)] [RED("quantityAmount")] 		public CInt32 QuantityAmount { get; set;}

		[Ordinal(0)] [RED("qualityThreshold")] 		public CInt32 QualityThreshold { get; set;}

		[Ordinal(0)] [RED("weightAmount")] 		public CFloat WeightAmount { get; set;}

		[Ordinal(0)] [RED("AHDAL_LOGIC_ANY")] 		public CInt32 AHDAL_LOGIC_ANY { get; set;}

		[Ordinal(0)] [RED("AHDAL_LOGIC_ALL")] 		public CInt32 AHDAL_LOGIC_ALL { get; set;}

		[Ordinal(0)] [RED("AHDAL_COMPARE_LESS")] 		public CInt32 AHDAL_COMPARE_LESS { get; set;}

		[Ordinal(0)] [RED("AHDAL_COMPARE_EQUAL")] 		public CInt32 AHDAL_COMPARE_EQUAL { get; set;}

		[Ordinal(0)] [RED("AHDAL_COMPARE_GREATER")] 		public CInt32 AHDAL_COMPARE_GREATER { get; set;}

		[Ordinal(0)] [RED("modInitalized")] 		public CBool ModInitalized { get; set;}

		[Ordinal(0)] [RED("modLoaded_base")] 		public CBool ModLoaded_base { get; set;}

		[Ordinal(0)] [RED("modLoaded_v200")] 		public CBool ModLoaded_v200 { get; set;}

		[Ordinal(0)] [RED("modLoaded_v210")] 		public CBool ModLoaded_v210 { get; set;}

		[Ordinal(0)] [RED("modLoaded_v300")] 		public CBool ModLoaded_v300 { get; set;}

		[Ordinal(0)] [RED("updateMsgParams", 2,0)] 		public CArray<CString> UpdateMsgParams { get; set;}

		public CAHDAutoLootConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAHDAutoLootConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}