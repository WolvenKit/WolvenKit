using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationSequenceDefinition : CVariable
	{
		[Ordinal(1)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(2)] [RED("manualSlotName")] 		public CName ManualSlotName { get; set;}

		[Ordinal(3)] [RED("parts", 2,0)] 		public CArray<SAnimationSequencePartDefinition> Parts { get; set;}

		[Ordinal(4)] [RED("freezeAtEnd")] 		public CBool FreezeAtEnd { get; set;}

		[Ordinal(5)] [RED("startForceEvent")] 		public CName StartForceEvent { get; set;}

		[Ordinal(6)] [RED("raiseEventOnEnd")] 		public CName RaiseEventOnEnd { get; set;}

		[Ordinal(7)] [RED("raiseForceEventOnEnd")] 		public CName RaiseForceEventOnEnd { get; set;}

		public SAnimationSequenceDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationSequenceDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}