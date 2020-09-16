using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangeAltitude : IBehTreeTask
	{
		[Ordinal(1)] [RED("HighFlightChance")] 		public CFloat HighFlightChance { get; set;}

		[Ordinal(2)] [RED("LowFlightChance")] 		public CFloat LowFlightChance { get; set;}

		[Ordinal(3)] [RED("LandChance")] 		public CFloat LandChance { get; set;}

		[Ordinal(4)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("onMain")] 		public CBool OnMain { get; set;}

		[Ordinal(7)] [RED("frequency")] 		public CFloat Frequency { get; set;}

		[Ordinal(8)] [RED("lastChange")] 		public CFloat LastChange { get; set;}

		public CBTTaskChangeAltitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChangeAltitude(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}