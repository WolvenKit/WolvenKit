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
		[RED("statPoints", 2,0)] 		public CArray<SBaseStat> StatPoints { get; set;}

		[RED("resistStats", 2,0)] 		public CArray<SResistanceValue> ResistStats { get; set;}

		[RED("blockedAbilities", 2,0)] 		public CArray<SBlockedAbility> BlockedAbilities { get; set;}

		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("charStats")] 		public CHandle<CCharacterStats> CharStats { get; set;}

		[RED("usedDifficultyMode")] 		public CEnum<EDifficultyMode> UsedDifficultyMode { get; set;}

		[RED("usedHealthType")] 		public CEnum<EBaseCharacterStats> UsedHealthType { get; set;}

		[RED("difficultyAbilities", 2,0)] 		public CArray<CArray<CName>> DifficultyAbilities { get; set;}

		[RED("ignoresDifficultySettings")] 		public CBool IgnoresDifficultySettings { get; set;}

		[RED("overhealBonus")] 		public CFloat OverhealBonus { get; set;}

		[RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		public W3AbilityManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AbilityManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}