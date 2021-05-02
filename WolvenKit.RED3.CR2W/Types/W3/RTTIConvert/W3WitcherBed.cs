using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WitcherBed : W3AnimationInteractionEntity
	{
		[Ordinal(1)] [RED("m_wasUsed")] 		public CBool M_wasUsed { get; set;}

		[Ordinal(2)] [RED("m_wereItemsRefilled")] 		public CBool M_wereItemsRefilled { get; set;}

		[Ordinal(3)] [RED("m_bedSaveLock")] 		public CInt32 M_bedSaveLock { get; set;}

		[Ordinal(4)] [RED("m_bedLevel")] 		public CInt32 M_bedLevel { get; set;}

		[Ordinal(5)] [RED("m_handsIkActive")] 		public CBool M_handsIkActive { get; set;}

		public W3WitcherBed(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}