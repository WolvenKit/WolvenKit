using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkill : CVariable
	{
		[Ordinal(1)] [RED("("skillType")] 		public CEnum<ESkill> SkillType { get; set;}

		[Ordinal(2)] [RED("("skillPath")] 		public CEnum<ESkillPath> SkillPath { get; set;}

		[Ordinal(3)] [RED("("skillSubPath")] 		public CEnum<ESkillSubPath> SkillSubPath { get; set;}

		[Ordinal(4)] [RED("("level")] 		public CInt32 Level { get; set;}

		[Ordinal(5)] [RED("("maxLevel")] 		public CInt32 MaxLevel { get; set;}

		[Ordinal(6)] [RED("("requiredSkills", 2,0)] 		public CArray<CEnum<ESkill>> RequiredSkills { get; set;}

		[Ordinal(7)] [RED("("requiredSkillsIsAlternative")] 		public CBool RequiredSkillsIsAlternative { get; set;}

		[Ordinal(8)] [RED("("requiredPointsSpent")] 		public CInt32 RequiredPointsSpent { get; set;}

		[Ordinal(9)] [RED("("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(10)] [RED("("cost")] 		public CInt32 Cost { get; set;}

		[Ordinal(11)] [RED("("isTemporary")] 		public CBool IsTemporary { get; set;}

		[Ordinal(12)] [RED("("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(13)] [RED("("modifierTags", 2,0)] 		public CArray<CName> ModifierTags { get; set;}

		[Ordinal(14)] [RED("("localisationNameKey")] 		public CString LocalisationNameKey { get; set;}

		[Ordinal(15)] [RED("("localisationDescriptionKey")] 		public CString LocalisationDescriptionKey { get; set;}

		[Ordinal(16)] [RED("("localisationDescriptionLevel2Key")] 		public CString LocalisationDescriptionLevel2Key { get; set;}

		[Ordinal(17)] [RED("("localisationDescriptionLevel3Key")] 		public CString LocalisationDescriptionLevel3Key { get; set;}

		[Ordinal(18)] [RED("("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(19)] [RED("("positionID")] 		public CInt32 PositionID { get; set;}

		[Ordinal(20)] [RED("("isNew")] 		public CBool IsNew { get; set;}

		[Ordinal(21)] [RED("("isCoreSkill")] 		public CBool IsCoreSkill { get; set;}

		[Ordinal(22)] [RED("("wasEquippedOnUIEnter")] 		public CBool WasEquippedOnUIEnter { get; set;}

		[Ordinal(23)] [RED("("remainingBlockedTime")] 		public CFloat RemainingBlockedTime { get; set;}

		[Ordinal(24)] [RED("("precachedModifierSkills", 2,0)] 		public CArray<CEnum<ESkill>> PrecachedModifierSkills { get; set;}

		public SSkill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}