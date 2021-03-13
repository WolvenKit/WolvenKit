using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SliderPopupData : TextPopupData
	{
		[Ordinal(1)] [RED("minValue")] 		public CInt32 MinValue { get; set;}

		[Ordinal(2)] [RED("maxValue")] 		public CInt32 MaxValue { get; set;}

		[Ordinal(3)] [RED("currentValue")] 		public CInt32 CurrentValue { get; set;}

		public SliderPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SliderPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}