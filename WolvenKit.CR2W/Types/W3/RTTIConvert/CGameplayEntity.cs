using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayEntity : CPeristentEntity
	{
		[RED("propertyAnimationSet")] 		public CPtr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

		[RED("displayName")] 		public LocalizedString DisplayName { get; set;}

		[RED("stats")] 		public CPtr<CCharacterStats> Stats { get; set;}

		[RED("isInteractionActivator")] 		public CBool IsInteractionActivator { get; set;}

		[RED("aimVector")] 		public Vector AimVector { get; set;}

		[RED("gameplayFlags")] 		public CUInt32 GameplayFlags { get; set;}

		[RED("focusModeVisibility")] 		public CEnum<EFocusModeVisibility> FocusModeVisibility { get; set;}

		[RED("minLootParamNumber")] 		public CInt32 MinLootParamNumber { get; set;}

		[RED("maxLootParamNumber")] 		public CInt32 MaxLootParamNumber { get; set;}

		[RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[RED("isHighlightedByMedallion")] 		public CBool IsHighlightedByMedallion { get; set;}

		[RED("isMagicalObject")] 		public CBool IsMagicalObject { get; set;}

		[RED("soundEntityName")] 		public CString SoundEntityName { get; set;}

		[RED("soundEntityGender")] 		public CString SoundEntityGender { get; set;}

		[RED("soundEntitySet")] 		public CString SoundEntitySet { get; set;}

		public CGameplayEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CGameplayEntity(cr2w);

	}
}