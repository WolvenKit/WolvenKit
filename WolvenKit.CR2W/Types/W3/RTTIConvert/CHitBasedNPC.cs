using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHitBasedNPC : CNewNPC
	{
		[RED("hitsToDeath")] 		public CInt32 HitsToDeath { get; set;}

		[RED("minTimeBetweenHits")] 		public CFloat MinTimeBetweenHits { get; set;}

		public CHitBasedNPC(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CHitBasedNPC(cr2w);

	}
}