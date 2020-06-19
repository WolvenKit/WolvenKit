using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurShadow : CVariable
	{
		[RED("shadowSigma")] 		public CFloat ShadowSigma { get; set;}

		[RED("shadowDensityScale")] 		public CFloat ShadowDensityScale { get; set;}

		[RED("castShadows")] 		public CBool CastShadows { get; set;}

		[RED("receiveShadows")] 		public CBool ReceiveShadows { get; set;}

		public SFurShadow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurShadow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}