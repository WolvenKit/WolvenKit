using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangeAltitudeDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("onMain")] 		public CBool OnMain { get; set;}

		[Ordinal(0)] [RED("HighFlightChance")] 		public CFloat HighFlightChance { get; set;}

		[Ordinal(0)] [RED("LowFlightChance")] 		public CFloat LowFlightChance { get; set;}

		[Ordinal(0)] [RED("LandChance")] 		public CFloat LandChance { get; set;}

		[Ordinal(0)] [RED("frequency")] 		public CFloat Frequency { get; set;}

		public CBTTaskChangeAltitudeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChangeAltitudeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}