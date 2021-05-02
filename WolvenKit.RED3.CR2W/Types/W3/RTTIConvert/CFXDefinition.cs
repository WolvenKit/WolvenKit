using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXDefinition : CObject
	{
		[Ordinal(1)] [RED("trackGroups", 2,0)] 		public CArray<CPtr<CFXTrackGroup>> TrackGroups { get; set;}

		[Ordinal(2)] [RED("length")] 		public CFloat Length { get; set;}

		[Ordinal(3)] [RED("loopStart")] 		public CFloat LoopStart { get; set;}

		[Ordinal(4)] [RED("loopEnd")] 		public CFloat LoopEnd { get; set;}

		[Ordinal(5)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(6)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(7)] [RED("showDistance")] 		public CFloat ShowDistance { get; set;}

		[Ordinal(8)] [RED("stayInMemory")] 		public CBool StayInMemory { get; set;}

		[Ordinal(9)] [RED("isLooped")] 		public CBool IsLooped { get; set;}

		[Ordinal(10)] [RED("randomStart")] 		public CBool RandomStart { get; set;}

		public CFXDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}