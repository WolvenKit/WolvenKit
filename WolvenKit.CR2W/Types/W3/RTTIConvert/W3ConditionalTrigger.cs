using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ConditionalTrigger : CEntity
	{
		[RED("conditionClass")] 		public CHandle<W3Condition> ConditionClass { get; set;}

		[RED("effectorClasses", 2,0)] 		public CArray<CHandle<IPerformableAction>> EffectorClasses { get; set;}

		[RED("affectsPlayer")] 		public CBool AffectsPlayer { get; set;}

		public W3ConditionalTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ConditionalTrigger(cr2w);

	}
}