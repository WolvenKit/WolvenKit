using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapDestructSelf : W3Trap
	{
		[Ordinal(1)] [RED("("playEffectOnDestruct")] 		public CName PlayEffectOnDestruct { get; set;}

		[Ordinal(2)] [RED("("onlyDestructOnAreaEnter")] 		public CBool OnlyDestructOnAreaEnter { get; set;}

		[Ordinal(3)] [RED("("denyAreaAfterDestruction")] 		public CBool DenyAreaAfterDestruction { get; set;}

		[Ordinal(4)] [RED("("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[Ordinal(5)] [RED("("excludesblockDestruction")] 		public CBool ExcludesblockDestruction { get; set;}

		[Ordinal(6)] [RED("("m_actorsInTrigger", 2,0)] 		public CArray<CHandle<CActor>> M_actorsInTrigger { get; set;}

		[Ordinal(7)] [RED("("m_isDestroyed")] 		public CBool M_isDestroyed { get; set;}

		public W3TrapDestructSelf(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapDestructSelf(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}