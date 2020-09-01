using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlightStyle : IBehTreeTask
	{
		[Ordinal(0)] [RED("("GlideChance")] 		public CFloat GlideChance { get; set;}

		[Ordinal(0)] [RED("("BackToRegularChance")] 		public CFloat BackToRegularChance { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("onMain")] 		public CBool OnMain { get; set;}

		[Ordinal(0)] [RED("("glideCheck")] 		public CBool GlideCheck { get; set;}

		[Ordinal(0)] [RED("("backToRegularCheck")] 		public CBool BackToRegularCheck { get; set;}

		[Ordinal(0)] [RED("("altitudeCheck")] 		public CBool AltitudeCheck { get; set;}

		[Ordinal(0)] [RED("("altitude")] 		public CFloat Altitude { get; set;}

		[Ordinal(0)] [RED("("frequency")] 		public CFloat Frequency { get; set;}

		[Ordinal(0)] [RED("("lastChange")] 		public CFloat LastChange { get; set;}

		[Ordinal(0)] [RED("("actorPosition")] 		public Vector ActorPosition { get; set;}

		public CBTTaskFlightStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlightStyle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}