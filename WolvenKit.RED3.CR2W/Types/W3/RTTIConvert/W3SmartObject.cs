using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SmartObject : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("startAnim")] 		public CName StartAnim { get; set;}

		[Ordinal(2)] [RED("loopAnims", 2,0)] 		public CArray<CName> LoopAnims { get; set;}

		[Ordinal(3)] [RED("stopAnim")] 		public CName StopAnim { get; set;}

		[Ordinal(4)] [RED("canBeInterruptedByInput")] 		public CBool CanBeInterruptedByInput { get; set;}

		[Ordinal(5)] [RED("m_currentUser")] 		public CHandle<CActor> M_currentUser { get; set;}

		[Ordinal(6)] [RED("m_saveLockID")] 		public CInt32 M_saveLockID { get; set;}

		[Ordinal(7)] [RED("possibleItemSlots", 2,0)] 		public CArray<CName> PossibleItemSlots { get; set;}

		public W3SmartObject(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SmartObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}