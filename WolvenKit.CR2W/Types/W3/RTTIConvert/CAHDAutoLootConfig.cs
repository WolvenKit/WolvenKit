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
		[RED("UserSettings")] 		public CHandle<CInGameConfigWrapper> UserSettings { get; set;}

		[RED("features")] 		public CHandle<CAHDAutoLootFeatureManager> Features { get; set;}

		[RED("filters")] 		public CHandle<CAHDAutoLootFilters> Filters { get; set;}

		[RED("actions")] 		public CHandle<CAHDAutoLootActions> Actions { get; set;}

		[RED("modEnabled")] 		public CBool ModEnabled { get; set;}

		[RED("useFilters")] 		public CBool UseFilters { get; set;}

		[RED("useNoAccidentalStealing")] 		public CBool UseNoAccidentalStealing { get; set;}

		[RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[RED("useIsHerb")] 		public CBool UseIsHerb { get; set;}

		[RED("useIsCorpse")] 		public CBool UseIsCorpse { get; set;}

		[RED("useIsArmor")] 		public CBool UseIsArmor { get; set;}

		[RED("useIsWeapon")] 		public CBool UseIsWeapon { get; set;}

		[RED("useIsUpgrade")] 		public CBool UseIsUpgrade { get; set;}

		[RED("useIsFood")] 		public CBool UseIsFood { get; set;}

		[RED("useIsFormula")] 		public CBool UseIsFormula { get; set;}

		[RED("useIsReadable")] 		public CBool UseIsReadable { get; set;}

		[RED("useIsIngredient")] 		public CBool UseIsIngredient { get; set;}

		[RED("useIsMoney")] 		public CBool UseIsMoney { get; set;}

		[RED("useIsNotJunk")] 		public CBool UseIsNotJunk { get; set;}

		[RED("useQuantity")] 		public CBool UseQuantity { get; set;}

		[RED("useWeight")] 		public CBool UseWeight { get; set;}

		[RED("useValue")] 		public CBool UseValue { get; set;}

		[RED("useItemQuality")] 		public CBool UseItemQuality { get; set;}

		[RED("enableTrueAutoLoot")] 		public CBool EnableTrueAutoLoot { get; set;}

		[RED("enableTrueAutoLootOnStart")] 		public CBool EnableTrueAutoLootOnStart { get; set;}

		[RED("filterLogic")] 		public CInt32 FilterLogic { get; set;}

		[RED("quantityLogic")] 		public CInt32 QuantityLogic { get; set;}

		[RED("weightLogic")] 		public CInt32 WeightLogic { get; set;}

		[RED("valueAmount")] 		public CInt32 ValueAmount { get; set;}

		[RED("valueLogic")] 		public CInt32 ValueLogic { get; set;}

		[RED("qualityLogic")] 		public CInt32 QualityLogic { get; set;}

		[RED("quantityAmount")] 		public CInt32 QuantityAmount { get; set;}

		[RED("qualityThreshold")] 		public CInt32 QualityThreshold { get; set;}

		[RED("weightAmount")] 		public CFloat WeightAmount { get; set;}

		[RED("AHDAL_LOGIC_ANY")] 		public CInt32 AHDAL_LOGIC_ANY { get; set;}

		[RED("AHDAL_LOGIC_ALL")] 		public CInt32 AHDAL_LOGIC_ALL { get; set;}

		[RED("AHDAL_COMPARE_LESS")] 		public CInt32 AHDAL_COMPARE_LESS { get; set;}

		[RED("AHDAL_COMPARE_EQUAL")] 		public CInt32 AHDAL_COMPARE_EQUAL { get; set;}

		[RED("AHDAL_COMPARE_GREATER")] 		public CInt32 AHDAL_COMPARE_GREATER { get; set;}

		[RED("modInitalized")] 		public CBool ModInitalized { get; set;}

		[RED("modLoaded_base")] 		public CBool ModLoaded_base { get; set;}

		[RED("modLoaded_v200")] 		public CBool ModLoaded_v200 { get; set;}

		[RED("modLoaded_v210")] 		public CBool ModLoaded_v210 { get; set;}

		[RED("modLoaded_v300")] 		public CBool ModLoaded_v300 { get; set;}

		[RED("updateMsgParams", 2,0)] 		public CArray<CString> UpdateMsgParams { get; set;}

		public CAHDAutoLootConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAHDAutoLootConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}