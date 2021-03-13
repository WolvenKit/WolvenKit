using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardActor : CModStoryBoardAsset
	{
		[Ordinal(1)] [RED("defaultIdleAnim")] 		public CName DefaultIdleAnim { get; set;}

		[Ordinal(2)] [RED("playerCloneTemplate")] 		public CString PlayerCloneTemplate { get; set;}

		[Ordinal(3)] [RED("appearanceNames", 2,0)] 		public CArray<CName> AppearanceNames { get; set;}

		[Ordinal(4)] [RED("appearanceId")] 		public CInt32 AppearanceId { get; set;}

		[Ordinal(5)] [RED("mimicsTriggerScene")] 		public CHandle<CStoryScene> MimicsTriggerScene { get; set;}

		[Ordinal(6)] [RED("isStaticLookAt")] 		public CBool IsStaticLookAt { get; set;}

		[Ordinal(7)] [RED("isActiveLookAt")] 		public CBool IsActiveLookAt { get; set;}

		[Ordinal(8)] [RED("cachedActorType")] 		public CEnum<EStoryBoardActorType> CachedActorType { get; set;}

		public CModStoryBoardActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}