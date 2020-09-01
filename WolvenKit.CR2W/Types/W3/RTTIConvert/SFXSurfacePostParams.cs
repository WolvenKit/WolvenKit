using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFXSurfacePostParams : CVariable
	{
		[Ordinal(1)] [RED("("fxFadeInTime")] 		public CFloat FxFadeInTime { get; set;}

		[Ordinal(2)] [RED("("fxLastingTime")] 		public CFloat FxLastingTime { get; set;}

		[Ordinal(3)] [RED("("fxFadeOutTime")] 		public CFloat FxFadeOutTime { get; set;}

		[Ordinal(4)] [RED("("fxRadius")] 		public CFloat FxRadius { get; set;}

		[Ordinal(5)] [RED("("fxType")] 		public CInt32 FxType { get; set;}

		public SFXSurfacePostParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFXSurfacePostParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}