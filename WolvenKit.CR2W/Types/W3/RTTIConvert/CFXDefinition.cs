using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXDefinition : CObject
	{
		[RED("trackGroups", 2,0)] 		public CArray<CPtr<CFXTrackGroup>> TrackGroups { get; set;}

		[RED("length")] 		public CFloat Length { get; set;}

		[RED("loopStart")] 		public CFloat LoopStart { get; set;}

		[RED("loopEnd")] 		public CFloat LoopEnd { get; set;}

		[RED("name")] 		public CName Name { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("showDistance")] 		public CFloat ShowDistance { get; set;}

		[RED("stayInMemory")] 		public CBool StayInMemory { get; set;}

		[RED("isLooped")] 		public CBool IsLooped { get; set;}

		[RED("randomStart")] 		public CBool RandomStart { get; set;}

		public CFXDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}