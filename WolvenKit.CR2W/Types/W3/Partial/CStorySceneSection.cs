using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CStorySceneSection : CStorySceneControlPart
	{
		[Ordinal(0)] [RED("contexID")] 		public CInt32 ContexID { get; set;}

		[Ordinal(0)] [RED("nextVariantId")] 		public CUInt32 NextVariantId { get; set;}

		[Ordinal(0)] [RED("defaultVariantId")] 		public CUInt32 DefaultVariantId { get; set;}

		[Ordinal(0)] [RED("variantIdForcedInEditor")] 		public CUInt32 VariantIdForcedInEditor { get; set;}

		[Ordinal(0)] [RED("variants", 2,0)] 		public CArray<CPtr<CStorySceneSectionVariant>> Variants { get; set;}

		[Ordinal(0)] [RED("localeVariantMappings", 2,0)] 		public CArray<CPtr<CStorySceneLocaleVariantMapping>> LocaleVariantMappings { get; set;}

		[Ordinal(0)] [RED("sceneElements", 2,0)] 		public CArray<CPtr<CStorySceneElement>> SceneElements { get; set;}

		[Ordinal(0)] [RED("events", 2,0)] 		public CArray<CPtr<CStorySceneEvent>> Events { get; set;}

		[Ordinal(0)] [RED("eventsInfo", 2,0)] 		public CArray<CPtr<CStorySceneEventInfo>> EventsInfo { get; set;}

		[Ordinal(0)] [RED("choice")] 		public CPtr<CStorySceneChoice> Choice { get; set;}

		[Ordinal(0)] [RED("sectionId")] 		public CUInt32 SectionId { get; set;}

		[Ordinal(0)] [RED("sectionName")] 		public CString SectionName { get; set;}

		[Ordinal(0)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(0)] [RED("interceptRadius")] 		public CFloat InterceptRadius { get; set;}

		[Ordinal(0)] [RED("interceptTimeout")] 		public CFloat InterceptTimeout { get; set;}

		[Ordinal(0)] [RED("interceptSections", 2,0)] 		public CArray<CPtr<CStorySceneSection>> InterceptSections { get; set;}

		[Ordinal(0)] [RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		[Ordinal(0)] [RED("isImportant")] 		public CBool IsImportant { get; set;}

		[Ordinal(0)] [RED("allowCameraMovement")] 		public CBool AllowCameraMovement { get; set;}

		[Ordinal(0)] [RED("hasCinematicOneliners")] 		public CBool HasCinematicOneliners { get; set;}

		[Ordinal(0)] [RED("manualFadeIn")] 		public CBool ManualFadeIn { get; set;}

		[Ordinal(0)] [RED("fadeInAtBeginning")] 		public CBool FadeInAtBeginning { get; set;}

		[Ordinal(0)] [RED("fadeOutAtEnd")] 		public CBool FadeOutAtEnd { get; set;}

		[Ordinal(0)] [RED("pauseInCombat")] 		public CBool PauseInCombat { get; set;}

		[Ordinal(0)] [RED("canBeSkipped")] 		public CBool CanBeSkipped { get; set;}

		[Ordinal(0)] [RED("canHaveLookats")] 		public CBool CanHaveLookats { get; set;}

		[Ordinal(0)] [RED("numberOfInputPaths")] 		public CUInt32 NumberOfInputPaths { get; set;}

		[Ordinal(0)] [RED("dialogsetChangeTo")] 		public CName DialogsetChangeTo { get; set;}

		[Ordinal(0)] [RED("forceDialogset")] 		public CBool ForceDialogset { get; set;}

		[Ordinal(0)] [RED("inputPathsElements", 2,0)] 		public CArray<CPtr<CStorySceneLinkElement>> InputPathsElements { get; set;}

		[Ordinal(0)] [RED("streamingLock")] 		public CBool StreamingLock { get; set;}

		[Ordinal(0)] [RED("streamingAreaTag")] 		public CName StreamingAreaTag { get; set;}

		[Ordinal(0)] [RED("streamingUseCameraPosition")] 		public CBool StreamingUseCameraPosition { get; set;}

		[Ordinal(0)] [RED("streamingCameraAllowedJumpDistance")] 		public CFloat StreamingCameraAllowedJumpDistance { get; set;}

		[Ordinal(0)] [RED("blockMusicTriggers")] 		public CBool BlockMusicTriggers { get; set;}

		[Ordinal(0)] [RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[Ordinal(0)] [RED("soundEventsOnEnd", 2,0)] 		public CArray<CName> SoundEventsOnEnd { get; set;}

		[Ordinal(0)] [RED("soundEventsOnSkip", 2,0)] 		public CArray<CName> SoundEventsOnSkip { get; set;}

		[Ordinal(0)] [RED("maxBoxExtentsToApplyHiResShadows")] 		public CFloat MaxBoxExtentsToApplyHiResShadows { get; set;}

		[Ordinal(0)] [RED("distantLightStartOverride")] 		public CFloat DistantLightStartOverride { get; set;}

		public CStorySceneSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneSection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}