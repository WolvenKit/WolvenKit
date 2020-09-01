using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AbilityManager : IScriptable
	{
		[Ordinal(0)] [RED("("statPoints", 2,0)] 		public CArray<SBaseStat> StatPoints { get; set;}

		[Ordinal(0)] [RED("("resistStats", 2,0)] 		public CArray<SResistanceValue> ResistStats { get; set;}

		[Ordinal(0)] [RED("("blockedAbilities", 2,0)] 		public CArray<SBlockedAbility> BlockedAbilities { get; set;}

		[Ordinal(0)] [RED("("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("("charStats")] 		public CHandle<CCharacterStats> CharStats { get; set;}

		[Ordinal(0)] [RED("("usedDifficultyMode")] 		public CEnum<EDifficultyMode> UsedDifficultyMode { get; set;}

		[Ordinal(0)] [RED("("usedHealthType")] 		public CEnum<EBaseCharacterStats> UsedHealthType { get; set;}

		[Ordinal(0)] [RED("("difficultyAbilities", 2,0)] 		public CArray<CArray<CName>> DifficultyAbilities { get; set;}

		[Ordinal(0)] [RED("("ignoresDifficultySettings")] 		public CBool IgnoresDifficultySettings { get; set;}

		[Ordinal(0)] [RED("("overhealBonus")] 		public CFloat OverhealBonus { get; set;}

		[Ordinal(0)] [RED("("isInitialized")] 		public CBool IsInitialized { get; set;}

		public W3AbilityManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AbilityManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}