using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CEntityTemplate : CResource
	{
		[RED("includes", 2,0)] 		public CArray<CHandle<CEntityTemplate>> Includes { get; set;}

		[RED("overrides", 2,0)] 		public CArray<SEntityTemplateOverride> Overrides { get; set;}

		[RED("properOverrides")] 		public CBool ProperOverrides { get; set;}

		[RED("backgroundOffset")] 		public Vector BackgroundOffset { get; set;}

		[RED("dataCompilationTime")] 		public CDateTime DataCompilationTime { get; set;}

		[RED("entityClass")] 		public CName EntityClass { get; set;}

		[RED("entityObject")] 		public CPtr<CEntity> EntityObject { get; set;}

		[RED("bodyParts", 2,0)] 		public CArray<CEntityBodyPart> BodyParts { get; set;}

		[RED("appearances", 2,0)] 		public CArray<CEntityAppearance> Appearances { get; set;}

		[RED("usedAppearances", 2,0)] 		public CArray<CName> UsedAppearances { get; set;}

		[RED("voicetagAppearances", 2,0)] 		public CArray<VoicetagAppearancePair> VoicetagAppearances { get; set;}

		[RED("effects", 2,0)] 		public CArray<CPtr<CFXDefinition>> Effects { get; set;}

		[RED("slots", 2,0)] 		public CArray<EntitySlot> Slots { get; set;}

		[RED("templateParams", 2,0)] 		public CArray<CPtr<CEntityTemplateParam>> TemplateParams { get; set;}

		[RED("coloringEntries", 2,0)] 		public CArray<SEntityTemplateColoringEntry> ColoringEntries { get; set;}

		[RED("instancePropEntries", 2,0)] 		public CArray<SComponentInstancePropertyEntry> InstancePropEntries { get; set;}

		[RED("flatCompiledData", 2,0)] 		public CByteArray FlatCompiledData { get; set;}

		[RED("streamedAttachments", 2,0)] 		public CArray<SStreamedAttachment> StreamedAttachments { get; set;}

		[RED("cookedEffects", 2,0)] 		public CArray<CEntityTemplateCookedEffect> CookedEffects { get; set;}

		[RED("cookedEffectsVersion")] 		public CUInt32 CookedEffectsVersion { get; set;}

		public CEntityTemplate(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CEntityTemplate(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}