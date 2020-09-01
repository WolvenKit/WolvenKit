using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CEntityTemplate : CResource
	{
		[Ordinal(0)] [RED("includes", 2,0)] 		public CArray<CHandle<CEntityTemplate>> Includes { get; set;}

		[Ordinal(0)] [RED("overrides", 2,0)] 		public CArray<SEntityTemplateOverride> Overrides { get; set;}

		[Ordinal(0)] [RED("properOverrides")] 		public CBool ProperOverrides { get; set;}

		[Ordinal(0)] [RED("backgroundOffset")] 		public Vector BackgroundOffset { get; set;}

		[Ordinal(0)] [RED("dataCompilationTime")] 		public CDateTime DataCompilationTime { get; set;}

		[Ordinal(0)] [RED("entityClass")] 		public CName EntityClass { get; set;}

		[Ordinal(0)] [RED("entityObject")] 		public CPtr<CEntity> EntityObject { get; set;}

		[Ordinal(0)] [RED("bodyParts", 2,0)] 		public CArray<CEntityBodyPart> BodyParts { get; set;}

		[Ordinal(0)] [RED("appearances", 2,0)] 		public CArray<CEntityAppearance> Appearances { get; set;}

		[Ordinal(0)] [RED("usedAppearances", 2,0)] 		public CArray<CName> UsedAppearances { get; set;}

		[Ordinal(0)] [RED("voicetagAppearances", 2,0)] 		public CArray<VoicetagAppearancePair> VoicetagAppearances { get; set;}

		[Ordinal(0)] [RED("effects", 2,0)] 		public CArray<CPtr<CFXDefinition>> Effects { get; set;}

		[Ordinal(0)] [RED("slots", 2,0)] 		public CArray<EntitySlot> Slots { get; set;}

		[Ordinal(0)] [RED("templateParams", 2,0)] 		public CArray<CPtr<CEntityTemplateParam>> TemplateParams { get; set;}

		[Ordinal(0)] [RED("coloringEntries", 2,0)] 		public CArray<SEntityTemplateColoringEntry> ColoringEntries { get; set;}

		[Ordinal(0)] [RED("instancePropEntries", 2,0)] 		public CArray<SComponentInstancePropertyEntry> InstancePropEntries { get; set;}

		[Ordinal(0)] [RED("flatCompiledData", 2,0)] 		public CByteArray FlatCompiledData { get; set;}

		[Ordinal(0)] [RED("streamedAttachments", 2,0)] 		public CArray<SStreamedAttachment> StreamedAttachments { get; set;}

		[Ordinal(0)] [RED("cookedEffects", 2,0)] 		public CArray<CEntityTemplateCookedEffect> CookedEffects { get; set;}

		[Ordinal(0)] [RED("cookedEffectsVersion")] 		public CUInt32 CookedEffectsVersion { get; set;}

		public CEntityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntityTemplate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}