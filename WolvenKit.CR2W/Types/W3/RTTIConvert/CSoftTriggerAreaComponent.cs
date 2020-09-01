using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoftTriggerAreaComponent : CTriggerAreaComponent
	{
		[Ordinal(1)] [RED("outerClippingAreaTags")] 		public TagList OuterClippingAreaTags { get; set;}

		[Ordinal(2)] [RED("outerIncludedChannels")] 		public ETriggerChannel OuterIncludedChannels { get; set;}

		[Ordinal(3)] [RED("outerExcludedChannels")] 		public ETriggerChannel OuterExcludedChannels { get; set;}

		[Ordinal(4)] [RED("invertPenetrationFraction")] 		public CBool InvertPenetrationFraction { get; set;}

		public CSoftTriggerAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSoftTriggerAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}