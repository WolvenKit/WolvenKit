using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFXSurfacePostParams : CVariable
	{
		[RED("fxFadeInTime")] 		public CFloat FxFadeInTime { get; set;}

		[RED("fxLastingTime")] 		public CFloat FxLastingTime { get; set;}

		[RED("fxFadeOutTime")] 		public CFloat FxFadeOutTime { get; set;}

		[RED("fxRadius")] 		public CFloat FxRadius { get; set;}

		[RED("fxType")] 		public CInt32 FxType { get; set;}

		public SFXSurfacePostParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFXSurfacePostParams(cr2w);

	}
}