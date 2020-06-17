using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAddBuffsDef : IBehTreeTaskDefinition
	{
		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("buffs", 2,0)] 		public CArray<EnumWrapper<EEffectType>> Buffs { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("customValue")] 		public SAbilityAttributeValue CustomValue { get; set;}

		public BTTaskAddBuffsDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskAddBuffsDef(cr2w);

	}
}