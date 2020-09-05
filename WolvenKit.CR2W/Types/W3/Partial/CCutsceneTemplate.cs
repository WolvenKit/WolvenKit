using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCutsceneTemplate : CSkeletalAnimationSet
	{
		[Ordinal(1)] [RED("modifiers", 2,0)] 		public CArray<CPtr<ICutsceneModifier>> Modifiers { get; set;}

		[Ordinal(2)] [RED("point")] 		public TagList Point { get; set;}

		[Ordinal(3)] [RED("lastLevelLoaded")] 		public CString LastLevelLoaded { get; set;}

		[Ordinal(4)] [RED("actorsDef", 2,0)] 		public CArray<SCutsceneActorDef> ActorsDef { get; set;}

		[Ordinal(5)] [RED("isValid")] 		public CBool IsValid { get; set;}

		[Ordinal(6)] [RED("fadeBefore")] 		public CFloat FadeBefore { get; set;}

		[Ordinal(7)] [RED("fadeAfter")] 		public CFloat FadeAfter { get; set;}

		[Ordinal(8)] [RED("cameraBlendInTime")] 		public CFloat CameraBlendInTime { get; set;}

		[Ordinal(9)] [RED("cameraBlendOutTime")] 		public CFloat CameraBlendOutTime { get; set;}

		[Ordinal(10)] [RED("blackscreenWhenLoading")] 		public CBool BlackscreenWhenLoading { get; set;}

		[Ordinal(11)] [RED("checkActorsPosition")] 		public CBool CheckActorsPosition { get; set;}

		[Ordinal(12)] [RED("entToHideTags", 2,0)] 		public CArray<CName> EntToHideTags { get; set;}

		[Ordinal(13)] [RED("usedInFiles", 2,0)] 		public CArray<CString> UsedInFiles { get; set;}

		[Ordinal(14)] [RED("resourcesToPreloadManually", 2,0)] 		public CArray<CHandle<CResource>> ResourcesToPreloadManually { get; set;}

		[Ordinal(15)] [RED("resourcesToPreloadManuallyPaths", 2,0)] 		public CArray<CString> ResourcesToPreloadManuallyPaths { get; set;}

		[Ordinal(16)] [RED("reverbName")] 		public CString ReverbName { get; set;}

		[Ordinal(17)] [RED("burnedAudioTrackName")] 		public StringAnsi BurnedAudioTrackName { get; set;}

		[Ordinal(18)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(19)] [RED("streamable")] 		public CBool Streamable { get; set;}

		[Ordinal(20)] [RED("effects", 2,0)] 		public CArray<CPtr<CFXDefinition>> Effects { get; set;}

		public CCutsceneTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCutsceneTemplate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}