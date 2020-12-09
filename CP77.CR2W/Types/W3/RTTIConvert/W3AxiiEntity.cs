using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AxiiEntity : W3SignEntity
	{
		[Ordinal(1)] [RED("effects", 2,0)] 		public CArray<SAxiiEffects> Effects { get; set;}

		[Ordinal(2)] [RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[Ordinal(3)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(4)] [RED("projSpeed")] 		public CFloat ProjSpeed { get; set;}

		[Ordinal(5)] [RED("targets", 2,0)] 		public CArray<CHandle<CActor>> Targets { get; set;}

		[Ordinal(6)] [RED("orientationTarget")] 		public CHandle<CActor> OrientationTarget { get; set;}

		public W3AxiiEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AxiiEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}