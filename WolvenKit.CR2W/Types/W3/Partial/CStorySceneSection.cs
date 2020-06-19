using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CStorySceneSection : CStorySceneControlPart
	{
		[RED("contexID")] 		public CInt32 ContexID { get; set;}

		[RED("nextVariantId")] 		public CUInt32 NextVariantId { get; set;}

		[RED("defaultVariantId")] 		public CUInt32 DefaultVariantId { get; set;}

		[RED("variants", 2,0)] 		public CArray<CPtr<CStorySceneSectionVariant>> Variants { get; set;}

		[RED("localeVariantMappings", 2,0)] 		public CArray<CPtr<CStorySceneLocaleVariantMapping>> LocaleVariantMappings { get; set;}

		[RED("sceneElements", 2,0)] 		public CArray<CPtr<CStorySceneElement>> SceneElements { get; set;}

		[RED("events", 2,0)] 		public CArray<CPtr<CStorySceneEvent>> Events { get; set;}

		[RED("eventsInfo", 2,0)] 		public CArray<CPtr<CStorySceneEventInfo>> EventsInfo { get; set;}

		[RED("choice")] 		public CPtr<CStorySceneChoice> Choice { get; set;}

		[RED("sectionId")] 		public CUInt32 SectionId { get; set;}

		[RED("sectionName")] 		public CString SectionName { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("interceptRadius")] 		public CFloat InterceptRadius { get; set;}

		[RED("interceptTimeout")] 		public CFloat InterceptTimeout { get; set;}

		[RED("interceptSections", 2,0)] 		public CArray<CPtr<CStorySceneSection>> InterceptSections { get; set;}

		[RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		[RED("isImportant")] 		public CBool IsImportant { get; set;}

		[RED("allowCameraMovement")] 		public CBool AllowCameraMovement { get; set;}

		[RED("hasCinematicOneliners")] 		public CBool HasCinematicOneliners { get; set;}

		[RED("manualFadeIn")] 		public CBool ManualFadeIn { get; set;}

		[RED("fadeInAtBeginning")] 		public CBool FadeInAtBeginning { get; set;}

		[RED("fadeOutAtEnd")] 		public CBool FadeOutAtEnd { get; set;}

		[RED("pauseInCombat")] 		public CBool PauseInCombat { get; set;}

		[RED("canBeSkipped")] 		public CBool CanBeSkipped { get; set;}

		[RED("canHaveLookats")] 		public CBool CanHaveLookats { get; set;}

		[RED("numberOfInputPaths")] 		public CUInt32 NumberOfInputPaths { get; set;}

		[RED("dialogsetChangeTo")] 		public CName DialogsetChangeTo { get; set;}

		[RED("forceDialogset")] 		public CBool ForceDialogset { get; set;}

		[RED("inputPathsElements", 2,0)] 		public CArray<CPtr<CStorySceneLinkElement>> InputPathsElements { get; set;}

		[RED("streamingLock")] 		public CBool StreamingLock { get; set;}

		[RED("streamingAreaTag")] 		public CName StreamingAreaTag { get; set;}

		[RED("streamingUseCameraPosition")] 		public CBool StreamingUseCameraPosition { get; set;}

		[RED("streamingCameraAllowedJumpDistance")] 		public CFloat StreamingCameraAllowedJumpDistance { get; set;}

		[RED("blockMusicTriggers")] 		public CBool BlockMusicTriggers { get; set;}

		[RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[RED("soundEventsOnEnd", 2,0)] 		public CArray<CName> SoundEventsOnEnd { get; set;}

		[RED("soundEventsOnSkip", 2,0)] 		public CArray<CName> SoundEventsOnSkip { get; set;}

		[RED("maxBoxExtentsToApplyHiResShadows")] 		public CFloat MaxBoxExtentsToApplyHiResShadows { get; set;}

		[RED("distantLightStartOverride")] 		public CFloat DistantLightStartOverride { get; set;}

		public CStorySceneSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneSection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}