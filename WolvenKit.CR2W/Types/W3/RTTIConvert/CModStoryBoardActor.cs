using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardActor : CModStoryBoardAsset
	{
		[Ordinal(0)] [RED("("defaultIdleAnim")] 		public CName DefaultIdleAnim { get; set;}

		[Ordinal(0)] [RED("("playerCloneTemplate")] 		public CString PlayerCloneTemplate { get; set;}

		[Ordinal(0)] [RED("("appearanceNames", 2,0)] 		public CArray<CName> AppearanceNames { get; set;}

		[Ordinal(0)] [RED("("appearanceId")] 		public CInt32 AppearanceId { get; set;}

		[Ordinal(0)] [RED("("mimicsTriggerScene")] 		public CHandle<CStoryScene> MimicsTriggerScene { get; set;}

		[Ordinal(0)] [RED("("isStaticLookAt")] 		public CBool IsStaticLookAt { get; set;}

		[Ordinal(0)] [RED("("isActiveLookAt")] 		public CBool IsActiveLookAt { get; set;}

		[Ordinal(0)] [RED("("cachedActorType")] 		public CEnum<EStoryBoardActorType> CachedActorType { get; set;}

		public CModStoryBoardActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}