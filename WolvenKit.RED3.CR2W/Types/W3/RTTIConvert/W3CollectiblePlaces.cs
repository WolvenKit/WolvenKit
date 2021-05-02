using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CollectiblePlaces : CGameplayEntity
	{
		[Ordinal(1)] [RED("xpPoints")] 		public CInt32 XpPoints { get; set;}

		[Ordinal(2)] [RED("wasDiscovered")] 		public CBool WasDiscovered { get; set;}

		[Ordinal(3)] [RED("allTags", 2,0)] 		public CArray<CName> AllTags { get; set;}

		public W3CollectiblePlaces(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CollectiblePlaces(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}