using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayEntity : CPeristentEntity
	{
		[Ordinal(1)] [RED("propertyAnimationSet")] 		public CPtr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

		[Ordinal(2)] [RED("displayName")] 		public LocalizedString DisplayName { get; set;}

		[Ordinal(3)] [RED("stats")] 		public CPtr<CCharacterStats> Stats { get; set;}

		[Ordinal(4)] [RED("isInteractionActivator")] 		public CBool IsInteractionActivator { get; set;}

		[Ordinal(5)] [RED("aimVector")] 		public Vector AimVector { get; set;}

		[Ordinal(6)] [RED("gameplayFlags")] 		public CUInt32 GameplayFlags { get; set;}

		[Ordinal(7)] [RED("focusModeVisibility")] 		public CEnum<EFocusModeVisibility> FocusModeVisibility { get; set;}

		[Ordinal(8)] [RED("minLootParamNumber")] 		public CInt32 MinLootParamNumber { get; set;}

		[Ordinal(9)] [RED("maxLootParamNumber")] 		public CInt32 MaxLootParamNumber { get; set;}

		[Ordinal(10)] [RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[Ordinal(11)] [RED("highlighted")] 		public CBool Highlighted { get; set;}

		[Ordinal(12)] [RED("focusModeSoundEffectType")] 		public CEnum<EFocusModeSoundEffectType> FocusModeSoundEffectType { get; set;}

		[Ordinal(13)] [RED("isPlayingFocusSound")] 		public CBool IsPlayingFocusSound { get; set;}

		[Ordinal(14)] [RED("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[Ordinal(15)] [RED("focusSoundVisualEffectBoneName")] 		public CName FocusSoundVisualEffectBoneName { get; set;}

		[Ordinal(16)] [RED("isHighlightedByMedallion")] 		public CBool IsHighlightedByMedallion { get; set;}

		[Ordinal(17)] [RED("isMagicalObject")] 		public CBool IsMagicalObject { get; set;}

		[Ordinal(18)] [RED("soundEntityName")] 		public CString SoundEntityName { get; set;}

		[Ordinal(19)] [RED("soundEntityGender")] 		public CString SoundEntityGender { get; set;}

		[Ordinal(20)] [RED("soundEntitySet")] 		public CString SoundEntitySet { get; set;}

		[Ordinal(21)] [RED("cutsceneForbiddenFXs", 2,0)] 		public CArray<CName> CutsceneForbiddenFXs { get; set;}

		public CGameplayEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameplayEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}