using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAHDAutoLootConfig : CObject
	{
		[Ordinal(1)] [RED("UserSettings")] 		public CHandle<CInGameConfigWrapper> UserSettings { get; set;}

		[Ordinal(2)] [RED("features")] 		public CHandle<CAHDAutoLootFeatureManager> Features { get; set;}

		[Ordinal(3)] [RED("filters")] 		public CHandle<CAHDAutoLootFilters> Filters { get; set;}

		[Ordinal(4)] [RED("actions")] 		public CHandle<CAHDAutoLootActions> Actions { get; set;}

		[Ordinal(5)] [RED("modEnabled")] 		public CBool ModEnabled { get; set;}

		[Ordinal(6)] [RED("useFilters")] 		public CBool UseFilters { get; set;}

		[Ordinal(7)] [RED("useNoAccidentalStealing")] 		public CBool UseNoAccidentalStealing { get; set;}

		[Ordinal(8)] [RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[Ordinal(9)] [RED("useIsHerb")] 		public CBool UseIsHerb { get; set;}

		[Ordinal(10)] [RED("useIsCorpse")] 		public CBool UseIsCorpse { get; set;}

		[Ordinal(11)] [RED("useIsArmor")] 		public CBool UseIsArmor { get; set;}

		[Ordinal(12)] [RED("useIsWeapon")] 		public CBool UseIsWeapon { get; set;}

		[Ordinal(13)] [RED("useIsUpgrade")] 		public CBool UseIsUpgrade { get; set;}

		[Ordinal(14)] [RED("useIsFood")] 		public CBool UseIsFood { get; set;}

		[Ordinal(15)] [RED("useIsFormula")] 		public CBool UseIsFormula { get; set;}

		[Ordinal(16)] [RED("useIsReadable")] 		public CBool UseIsReadable { get; set;}

		[Ordinal(17)] [RED("useIsIngredient")] 		public CBool UseIsIngredient { get; set;}

		[Ordinal(18)] [RED("useIsMoney")] 		public CBool UseIsMoney { get; set;}

		[Ordinal(19)] [RED("useIsNotJunk")] 		public CBool UseIsNotJunk { get; set;}

		[Ordinal(20)] [RED("useQuantity")] 		public CBool UseQuantity { get; set;}

		[Ordinal(21)] [RED("useWeight")] 		public CBool UseWeight { get; set;}

		[Ordinal(22)] [RED("useValue")] 		public CBool UseValue { get; set;}

		[Ordinal(23)] [RED("useItemQuality")] 		public CBool UseItemQuality { get; set;}

		[Ordinal(24)] [RED("enableTrueAutoLoot")] 		public CBool EnableTrueAutoLoot { get; set;}

		[Ordinal(25)] [RED("enableTrueAutoLootOnStart")] 		public CBool EnableTrueAutoLootOnStart { get; set;}

		[Ordinal(26)] [RED("filterLogic")] 		public CInt32 FilterLogic { get; set;}

		[Ordinal(27)] [RED("quantityLogic")] 		public CInt32 QuantityLogic { get; set;}

		[Ordinal(28)] [RED("weightLogic")] 		public CInt32 WeightLogic { get; set;}

		[Ordinal(29)] [RED("valueAmount")] 		public CInt32 ValueAmount { get; set;}

		[Ordinal(30)] [RED("valueLogic")] 		public CInt32 ValueLogic { get; set;}

		[Ordinal(31)] [RED("qualityLogic")] 		public CInt32 QualityLogic { get; set;}

		[Ordinal(32)] [RED("quantityAmount")] 		public CInt32 QuantityAmount { get; set;}

		[Ordinal(33)] [RED("qualityThreshold")] 		public CInt32 QualityThreshold { get; set;}

		[Ordinal(34)] [RED("weightAmount")] 		public CFloat WeightAmount { get; set;}

		[Ordinal(35)] [RED("AHDAL_LOGIC_ANY")] 		public CInt32 AHDAL_LOGIC_ANY { get; set;}

		[Ordinal(36)] [RED("AHDAL_LOGIC_ALL")] 		public CInt32 AHDAL_LOGIC_ALL { get; set;}

		[Ordinal(37)] [RED("AHDAL_COMPARE_LESS")] 		public CInt32 AHDAL_COMPARE_LESS { get; set;}

		[Ordinal(38)] [RED("AHDAL_COMPARE_EQUAL")] 		public CInt32 AHDAL_COMPARE_EQUAL { get; set;}

		[Ordinal(39)] [RED("AHDAL_COMPARE_GREATER")] 		public CInt32 AHDAL_COMPARE_GREATER { get; set;}

		[Ordinal(40)] [RED("modInitalized")] 		public CBool ModInitalized { get; set;}

		[Ordinal(41)] [RED("modLoaded_base")] 		public CBool ModLoaded_base { get; set;}

		[Ordinal(42)] [RED("modLoaded_v200")] 		public CBool ModLoaded_v200 { get; set;}

		[Ordinal(43)] [RED("modLoaded_v210")] 		public CBool ModLoaded_v210 { get; set;}

		[Ordinal(44)] [RED("modLoaded_v300")] 		public CBool ModLoaded_v300 { get; set;}

		[Ordinal(45)] [RED("updateMsgParams", 2,0)] 		public CArray<CString> UpdateMsgParams { get; set;}

		public CAHDAutoLootConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAHDAutoLootConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}