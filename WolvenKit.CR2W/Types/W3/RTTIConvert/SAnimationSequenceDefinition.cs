using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationSequenceDefinition : CVariable
	{
		[Ordinal(0)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(0)] [RED("manualSlotName")] 		public CName ManualSlotName { get; set;}

		[Ordinal(0)] [RED("parts", 2,0)] 		public CArray<SAnimationSequencePartDefinition> Parts { get; set;}

		[Ordinal(0)] [RED("freezeAtEnd")] 		public CBool FreezeAtEnd { get; set;}

		[Ordinal(0)] [RED("startForceEvent")] 		public CName StartForceEvent { get; set;}

		[Ordinal(0)] [RED("raiseEventOnEnd")] 		public CName RaiseEventOnEnd { get; set;}

		[Ordinal(0)] [RED("raiseForceEventOnEnd")] 		public CName RaiseForceEventOnEnd { get; set;}

		public SAnimationSequenceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationSequenceDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}