using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCutsceneTemplate : CSkeletalAnimationSet
	{
		[Ordinal(0)] [RED("modifiers", 2,0)] 		public CArray<CPtr<ICutsceneModifier>> Modifiers { get; set;}

		[Ordinal(0)] [RED("point")] 		public TagList Point { get; set;}

		[Ordinal(0)] [RED("lastLevelLoaded")] 		public CString LastLevelLoaded { get; set;}

		[Ordinal(0)] [RED("actorsDef", 2,0)] 		public CArray<SCutsceneActorDef> ActorsDef { get; set;}

		[Ordinal(0)] [RED("isValid")] 		public CBool IsValid { get; set;}

		[Ordinal(0)] [RED("fadeBefore")] 		public CFloat FadeBefore { get; set;}

		[Ordinal(0)] [RED("fadeAfter")] 		public CFloat FadeAfter { get; set;}

		[Ordinal(0)] [RED("cameraBlendInTime")] 		public CFloat CameraBlendInTime { get; set;}

		[Ordinal(0)] [RED("cameraBlendOutTime")] 		public CFloat CameraBlendOutTime { get; set;}

		[Ordinal(0)] [RED("blackscreenWhenLoading")] 		public CBool BlackscreenWhenLoading { get; set;}

		[Ordinal(0)] [RED("checkActorsPosition")] 		public CBool CheckActorsPosition { get; set;}

		[Ordinal(0)] [RED("entToHideTags", 2,0)] 		public CArray<CName> EntToHideTags { get; set;}

		[Ordinal(0)] [RED("usedInFiles", 2,0)] 		public CArray<CString> UsedInFiles { get; set;}

		[Ordinal(0)] [RED("resourcesToPreloadManually", 2,0)] 		public CArray<CHandle<CResource>> ResourcesToPreloadManually { get; set;}

		[Ordinal(0)] [RED("resourcesToPreloadManuallyPaths", 2,0)] 		public CArray<CString> ResourcesToPreloadManuallyPaths { get; set;}

		[Ordinal(0)] [RED("reverbName")] 		public CString ReverbName { get; set;}

		[Ordinal(0)] [RED("burnedAudioTrackName")] 		public StringAnsi BurnedAudioTrackName { get; set;}

		[Ordinal(0)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(0)] [RED("streamable")] 		public CBool Streamable { get; set;}

		[Ordinal(0)] [RED("effects", 2,0)] 		public CArray<CPtr<CFXDefinition>> Effects { get; set;}

		public CCutsceneTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCutsceneTemplate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}