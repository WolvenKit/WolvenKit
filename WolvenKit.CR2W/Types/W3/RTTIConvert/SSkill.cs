using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkill : CVariable
	{
		[RED("skillType")] 		public CEnum<ESkill> SkillType { get; set;}

		[RED("skillPath")] 		public CEnum<ESkillPath> SkillPath { get; set;}

		[RED("skillSubPath")] 		public CEnum<ESkillSubPath> SkillSubPath { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("maxLevel")] 		public CInt32 MaxLevel { get; set;}

		[RED("requiredSkills", 2,0)] 		public CArray<CEnum<ESkill>> RequiredSkills { get; set;}

		[RED("requiredSkillsIsAlternative")] 		public CBool RequiredSkillsIsAlternative { get; set;}

		[RED("requiredPointsSpent")] 		public CInt32 RequiredPointsSpent { get; set;}

		[RED("priority")] 		public CInt32 Priority { get; set;}

		[RED("cost")] 		public CInt32 Cost { get; set;}

		[RED("isTemporary")] 		public CBool IsTemporary { get; set;}

		[RED("abilityName")] 		public CName AbilityName { get; set;}

		[RED("modifierTags", 2,0)] 		public CArray<CName> ModifierTags { get; set;}

		[RED("localisationNameKey")] 		public CString LocalisationNameKey { get; set;}

		[RED("localisationDescriptionKey")] 		public CString LocalisationDescriptionKey { get; set;}

		[RED("localisationDescriptionLevel2Key")] 		public CString LocalisationDescriptionLevel2Key { get; set;}

		[RED("localisationDescriptionLevel3Key")] 		public CString LocalisationDescriptionLevel3Key { get; set;}

		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("positionID")] 		public CInt32 PositionID { get; set;}

		[RED("isNew")] 		public CBool IsNew { get; set;}

		[RED("isCoreSkill")] 		public CBool IsCoreSkill { get; set;}

		[RED("wasEquippedOnUIEnter")] 		public CBool WasEquippedOnUIEnter { get; set;}

		[RED("remainingBlockedTime")] 		public CFloat RemainingBlockedTime { get; set;}

		[RED("precachedModifierSkills", 2,0)] 		public CArray<CEnum<ESkill>> PrecachedModifierSkills { get; set;}

		public SSkill(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSkill(cr2w);

	}
}