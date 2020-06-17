using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CStorySceneSection : CStorySceneControlPart
    {
        [RED("contexID")] public CInt32 ContexID { get; set; }

        [RED("nextVariantId")] public CUInt32 NextVariantId { get; set; }

        [RED("defaultVariantId")] public CUInt32 DefaultVariantId { get; set; }

        [RED("variants", 2, 0)] public CArray<CPtr<CStorySceneSectionVariant>> Variants { get; set; }

        [RED("localeVariantMappings", 2, 0)] public CArray<CPtr<CStorySceneLocaleVariantMapping>> LocaleVariantMappings { get; set; }

        [RED("sceneElements", 2, 0)] public CArray<CPtr<CStorySceneElement>> SceneElements { get; set; }

        [RED("events", 2, 0)] public CArray<CPtr<CStorySceneEvent>> Events { get; set; }

        [RED("eventsInfo", 2, 0)] public CArray<CPtr<CStorySceneEventInfo>> EventsInfo { get; set; }

        [RED("choice")] public CPtr<CStorySceneChoice> Choice { get; set; }

        [RED("sectionId")] public CUInt32 SectionId { get; set; }

        [RED("sectionName")] public CString SectionName { get; set; }

        [RED("tags")] public TagList Tags { get; set; }

        [RED("interceptRadius")] public CFloat InterceptRadius { get; set; }

        [RED("interceptTimeout")] public CFloat InterceptTimeout { get; set; }

        [RED("interceptSections", 2, 0)] public CArray<CPtr<CStorySceneSection>> InterceptSections { get; set; }

        [RED("isGameplay")] public CBool IsGameplay { get; set; }

        [RED("isImportant")] public CBool IsImportant { get; set; }

        [RED("allowCameraMovement")] public CBool AllowCameraMovement { get; set; }

        [RED("hasCinematicOneliners")] public CBool HasCinematicOneliners { get; set; }

        [RED("manualFadeIn")] public CBool ManualFadeIn { get; set; }

        [RED("fadeInAtBeginning")] public CBool FadeInAtBeginning { get; set; }

        [RED("fadeOutAtEnd")] public CBool FadeOutAtEnd { get; set; }

        [RED("pauseInCombat")] public CBool PauseInCombat { get; set; }

        [RED("canBeSkipped")] public CBool CanBeSkipped { get; set; }

        [RED("canHaveLookats")] public CBool CanHaveLookats { get; set; }

        [RED("numberOfInputPaths")] public CUInt32 NumberOfInputPaths { get; set; }

        [RED("dialogsetChangeTo")] public CName DialogsetChangeTo { get; set; }

        [RED("forceDialogset")] public CBool ForceDialogset { get; set; }

        [RED("inputPathsElements", 2, 0)] public CArray<CPtr<CStorySceneLinkElement>> InputPathsElements { get; set; }

        [RED("streamingLock")] public CBool StreamingLock { get; set; }

        [RED("streamingAreaTag")] public CName StreamingAreaTag { get; set; }

        [RED("streamingUseCameraPosition")] public CBool StreamingUseCameraPosition { get; set; }

        [RED("streamingCameraAllowedJumpDistance")] public CFloat StreamingCameraAllowedJumpDistance { get; set; }

        [RED("blockMusicTriggers")] public CBool BlockMusicTriggers { get; set; }

        [RED("soundListenerOverride")] public CString SoundListenerOverride { get; set; }

        [RED("soundEventsOnEnd", 2, 0)] public CArray<CName> SoundEventsOnEnd { get; set; }

        [RED("soundEventsOnSkip", 2, 0)] public CArray<CName> SoundEventsOnSkip { get; set; }

        [RED("maxBoxExtentsToApplyHiResShadows")] public CFloat MaxBoxExtentsToApplyHiResShadows { get; set; }

        [RED("distantLightStartOverride")] public CFloat DistantLightStartOverride { get; set; }

        [REDBuffer] public CArray<CVariableWrapper> sceneEventElements { get; set; }

        public CStorySceneSection(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            //var count = file.ReadInt32();
            //for (var i = 0; i < count; i++)
            //{
            //    var elementsize = file.ReadUInt32();
            //    var typeId = file.ReadUInt16();
            //    var typeName = cr2w.names[typeId].Str;

            //    var item = CR2WTypeManager.Get().GetByName(typeName, "", cr2w, false) ?? new CVector(cr2w);

            //    item.Read(file, elementsize);
            //    item.Type = typeName;
            //    sceneEventElements.Add(item);
            //}
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            //file.Write((uint) sceneEventElements.Count);
            //foreach (var item in sceneEventElements)
            //{
            //    var startpos = file.BaseStream.Position;

            //    file.Write((uint) 0);
            //    file.Write(item.typeId);

            //    item.Write(file);

            //    var endpos = file.BaseStream.Position;
            //    var newsize = (uint) (endpos - startpos);

            //    file.Seek((int) startpos, SeekOrigin.Begin);
            //    file.Write(newsize);
            //    file.Seek((int) endpos, SeekOrigin.Begin);
            //}
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CStorySceneSection(cr2w);
        }
    }
}