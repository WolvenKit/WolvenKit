using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneLightEvent : CExtAnimEvent
	{
		[Ordinal(1)] [RED("tag")] 		public TagList Tag { get; set;}

		[Ordinal(2)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(3)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(4)] [RED("brightness")] 		public CFloat Brightness { get; set;}

		[Ordinal(5)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(6)] [RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		public CExtAnimCutsceneLightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneLightEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}