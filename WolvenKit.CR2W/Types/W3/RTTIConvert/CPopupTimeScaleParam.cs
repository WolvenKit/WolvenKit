using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPopupTimeScaleParam : IPopupTimeParam
	{
		[Ordinal(0)] [RED("timeScale")] 		public CFloat TimeScale { get; set;}

		[Ordinal(0)] [RED("multiplicative")] 		public CBool Multiplicative { get; set;}

		public CPopupTimeScaleParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPopupTimeScaleParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}