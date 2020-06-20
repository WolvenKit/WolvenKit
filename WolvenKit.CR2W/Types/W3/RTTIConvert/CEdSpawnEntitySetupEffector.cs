using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEdSpawnEntitySetupEffector : IEdEntitySetupEffector
	{
		[RED("template")] 		public CSoft<CEntityTemplate> Template { get; set;}

		[RED("localPosition")] 		public Vector LocalPosition { get; set;}

		[RED("localOrientation")] 		public EulerAngles LocalOrientation { get; set;}

		[RED("detachTemplate")] 		public CBool DetachTemplate { get; set;}

		[RED("extraTags")] 		public TagList ExtraTags { get; set;}

		public CEdSpawnEntitySetupEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEdSpawnEntitySetupEffector(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}