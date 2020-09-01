using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTaunt : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("("tauntType")] 		public CEnum<ETauntType> TauntType { get; set;}

		[Ordinal(2)] [RED("("tauntDelay")] 		public CFloat TauntDelay { get; set;}

		[Ordinal(3)] [RED("("useXMLTauntChance")] 		public CBool UseXMLTauntChance { get; set;}

		[Ordinal(4)] [RED("("chance")] 		public CInt32 Chance { get; set;}

		[Ordinal(5)] [RED("("timeStamp")] 		public CFloat TimeStamp { get; set;}

		public CBTTaskTaunt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTaunt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}