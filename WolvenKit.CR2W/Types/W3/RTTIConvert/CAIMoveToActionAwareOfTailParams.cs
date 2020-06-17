using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveToActionAwareOfTailParams : CAIMoveToParams
	{
		[RED("tailTag")] 		public CName TailTag { get; set;}

		[RED("startMovementDistance")] 		public CFloat StartMovementDistance { get; set;}

		[RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		public CAIMoveToActionAwareOfTailParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMoveToActionAwareOfTailParams(cr2w);

	}
}