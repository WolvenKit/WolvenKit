using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChanceFromStatDef : IBehTreeConditionalTaskDefinition
	{
		[RED("ifNot")] 		public CBool IfNot { get; set;}

		[RED("statName")] 		public CName StatName { get; set;}

		[RED("frequency")] 		public CFloat Frequency { get; set;}

		[RED("scaleWithNumberOfOpponents")] 		public CBool ScaleWithNumberOfOpponents { get; set;}

		[RED("chancePerOpponent")] 		public CInt32 ChancePerOpponent { get; set;}

		public CBTTaskChanceFromStatDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskChanceFromStatDef(cr2w);

	}
}