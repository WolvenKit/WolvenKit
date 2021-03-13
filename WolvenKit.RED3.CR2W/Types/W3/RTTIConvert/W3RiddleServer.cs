using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3RiddleServer : CGameplayEntity
	{
		[Ordinal(1)] [RED("OnGoodCombinationEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> OnGoodCombinationEvents { get; set;}

		[Ordinal(2)] [RED("pairedNodes", 2,0)] 		public CArray<EntityHandle> PairedNodes { get; set;}

		[Ordinal(3)] [RED("riddleNodesNumber")] 		public CInt32 RiddleNodesNumber { get; set;}

		[Ordinal(4)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(5)] [RED("nodesAtValidPosNumber")] 		public CInt32 NodesAtValidPosNumber { get; set;}

		public W3RiddleServer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3RiddleServer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}