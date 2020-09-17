using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlightStyleDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(2)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(3)] [RED("onMain")] 		public CBool OnMain { get; set;}

		[Ordinal(4)] [RED("glideCheck")] 		public CBool GlideCheck { get; set;}

		[Ordinal(5)] [RED("backToRegularCheck")] 		public CBool BackToRegularCheck { get; set;}

		[Ordinal(6)] [RED("altitudeCheck")] 		public CBool AltitudeCheck { get; set;}

		[Ordinal(7)] [RED("GlideChance")] 		public CFloat GlideChance { get; set;}

		[Ordinal(8)] [RED("BackToRegularChance")] 		public CFloat BackToRegularChance { get; set;}

		[Ordinal(9)] [RED("altitude")] 		public CFloat Altitude { get; set;}

		[Ordinal(10)] [RED("frequency")] 		public CFloat Frequency { get; set;}

		public CBTTaskFlightStyleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlightStyleDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}