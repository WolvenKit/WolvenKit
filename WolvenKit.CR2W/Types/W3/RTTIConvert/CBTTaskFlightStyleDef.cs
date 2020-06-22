using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlightStyleDef : IBehTreeTaskDefinition
	{
		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onMain")] 		public CBool OnMain { get; set;}

		[RED("glideCheck")] 		public CBool GlideCheck { get; set;}

		[RED("backToRegularCheck")] 		public CBool BackToRegularCheck { get; set;}

		[RED("altitudeCheck")] 		public CBool AltitudeCheck { get; set;}

		[RED("GlideChance")] 		public CFloat GlideChance { get; set;}

		[RED("BackToRegularChance")] 		public CFloat BackToRegularChance { get; set;}

		[RED("altitude")] 		public CFloat Altitude { get; set;}

		[RED("frequency")] 		public CFloat Frequency { get; set;}

		public CBTTaskFlightStyleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlightStyleDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}