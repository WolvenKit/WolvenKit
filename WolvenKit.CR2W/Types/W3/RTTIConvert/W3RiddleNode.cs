using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3RiddleNode : CGameplayEntity
	{
		[Ordinal(0)] [RED("("positions", 2,0)] 		public CArray<SRiddleNodePositionDef> Positions { get; set;}

		[Ordinal(0)] [RED("("riddleServerTag")] 		public CName RiddleServerTag { get; set;}

		[Ordinal(0)] [RED("("factOnPositionValid")] 		public CString FactOnPositionValid { get; set;}

		[Ordinal(0)] [RED("("useFocusModeHelper")] 		public CBool UseFocusModeHelper { get; set;}

		[Ordinal(0)] [RED("("currentPos")] 		public CInt32 CurrentPos { get; set;}

		[Ordinal(0)] [RED("("rewind")] 		public CBool Rewind { get; set;}

		[Ordinal(0)] [RED("("currentPairedRiddleNodeID")] 		public CInt32 CurrentPairedRiddleNodeID { get; set;}

		[Ordinal(0)] [RED("("currentPairedRiddleNodesIDS", 2,0)] 		public CArray<CInt32> CurrentPairedRiddleNodesIDS { get; set;}

		[Ordinal(0)] [RED("("riddleServer")] 		public CHandle<W3RiddleServer> RiddleServer { get; set;}

		[Ordinal(0)] [RED("("wasAddedToServer")] 		public CBool WasAddedToServer { get; set;}

		[Ordinal(0)] [RED("("lastPosID")] 		public CInt32 LastPosID { get; set;}

		[Ordinal(0)] [RED("("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(0)] [RED("("isEffectOn")] 		public CBool IsEffectOn { get; set;}

		[Ordinal(0)] [RED("("isOnValidPosition")] 		public CBool IsOnValidPosition { get; set;}

		[Ordinal(0)] [RED("("initializeServerCounter")] 		public CInt32 InitializeServerCounter { get; set;}

		public W3RiddleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3RiddleNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}