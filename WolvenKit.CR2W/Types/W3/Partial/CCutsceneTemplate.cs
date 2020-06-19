using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCutsceneTemplate : CSkeletalAnimationSet
	{
		[RED("modifiers", 2,0)] 		public CArray<CPtr<ICutsceneModifier>> Modifiers { get; set;}

		[RED("point")] 		public TagList Point { get; set;}

		[RED("lastLevelLoaded")] 		public CString LastLevelLoaded { get; set;}

		[RED("actorsDef", 2,0)] 		public CArray<SCutsceneActorDef> ActorsDef { get; set;}

		[RED("isValid")] 		public CBool IsValid { get; set;}

		[RED("fadeBefore")] 		public CFloat FadeBefore { get; set;}

		[RED("fadeAfter")] 		public CFloat FadeAfter { get; set;}

		[RED("cameraBlendInTime")] 		public CFloat CameraBlendInTime { get; set;}

		[RED("cameraBlendOutTime")] 		public CFloat CameraBlendOutTime { get; set;}

		[RED("blackscreenWhenLoading")] 		public CBool BlackscreenWhenLoading { get; set;}

		[RED("checkActorsPosition")] 		public CBool CheckActorsPosition { get; set;}

		[RED("entToHideTags", 2,0)] 		public CArray<CName> EntToHideTags { get; set;}

		[RED("usedInFiles", 2,0)] 		public CArray<CString> UsedInFiles { get; set;}

		[RED("resourcesToPreloadManuallyPaths", 2,0)] 		public CArray<CString> ResourcesToPreloadManuallyPaths { get; set;}

		[RED("reverbName")] 		public CString ReverbName { get; set;}

		[RED("burnedAudioTrackName")] 		public StringAnsi BurnedAudioTrackName { get; set;}

		[RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[RED("streamable")] 		public CBool Streamable { get; set;}

		[RED("effects", 2,0)] 		public CArray<CPtr<CFXDefinition>> Effects { get; set;}

		public CCutsceneTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCutsceneTemplate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}