using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3RiddleNode : CGameplayEntity
	{
		[Ordinal(1)] [RED("positions", 2,0)] 		public CArray<SRiddleNodePositionDef> Positions { get; set;}

		[Ordinal(2)] [RED("riddleServerTag")] 		public CName RiddleServerTag { get; set;}

		[Ordinal(3)] [RED("factOnPositionValid")] 		public CString FactOnPositionValid { get; set;}

		[Ordinal(4)] [RED("useFocusModeHelper")] 		public CBool UseFocusModeHelper { get; set;}

		[Ordinal(5)] [RED("currentPos")] 		public CInt32 CurrentPos { get; set;}

		[Ordinal(6)] [RED("rewind")] 		public CBool Rewind { get; set;}

		[Ordinal(7)] [RED("currentPairedRiddleNodeID")] 		public CInt32 CurrentPairedRiddleNodeID { get; set;}

		[Ordinal(8)] [RED("currentPairedRiddleNodesIDS", 2,0)] 		public CArray<CInt32> CurrentPairedRiddleNodesIDS { get; set;}

		[Ordinal(9)] [RED("riddleServer")] 		public CHandle<W3RiddleServer> RiddleServer { get; set;}

		[Ordinal(10)] [RED("wasAddedToServer")] 		public CBool WasAddedToServer { get; set;}

		[Ordinal(11)] [RED("lastPosID")] 		public CInt32 LastPosID { get; set;}

		[Ordinal(12)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(13)] [RED("isEffectOn")] 		public CBool IsEffectOn { get; set;}

		[Ordinal(14)] [RED("isOnValidPosition")] 		public CBool IsOnValidPosition { get; set;}

		[Ordinal(15)] [RED("initializeServerCounter")] 		public CInt32 InitializeServerCounter { get; set;}

		public W3RiddleNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}