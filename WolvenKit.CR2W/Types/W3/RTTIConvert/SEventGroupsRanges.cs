using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEventGroupsRanges : CVariable
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("beginIndex")] 		public CUInt32 BeginIndex { get; set;}

		[RED("endIndex")] 		public CUInt32 EndIndex { get; set;}

		public SEventGroupsRanges(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEventGroupsRanges(cr2w);

	}
}