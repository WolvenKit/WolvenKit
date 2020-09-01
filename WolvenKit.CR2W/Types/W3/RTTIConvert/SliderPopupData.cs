using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SliderPopupData : TextPopupData
	{
		[Ordinal(0)] [RED("("minValue")] 		public CInt32 MinValue { get; set;}

		[Ordinal(0)] [RED("("maxValue")] 		public CInt32 MaxValue { get; set;}

		[Ordinal(0)] [RED("("currentValue")] 		public CInt32 CurrentValue { get; set;}

		public SliderPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SliderPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}