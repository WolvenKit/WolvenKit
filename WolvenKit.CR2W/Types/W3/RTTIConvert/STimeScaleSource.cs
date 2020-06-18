using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STimescaleSource : CVariable
	{
		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("sourceType")] 		public CEnum<ETimescaleSource> SourceType { get; set;}

		[RED("sourcePriority")] 		public CInt32 SourcePriority { get; set;}

		public STimescaleSource(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new STimescaleSource(cr2w);

	}
}