using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3RiddleNode : CGameplayEntity
	{
		[RED("positions", 2,0)] 		public CArray<SRiddleNodePositionDef> Positions { get; set;}

		[RED("riddleServerTag")] 		public CName RiddleServerTag { get; set;}

		[RED("factOnPositionValid")] 		public CString FactOnPositionValid { get; set;}

		[RED("useFocusModeHelper")] 		public CBool UseFocusModeHelper { get; set;}

		public W3RiddleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3RiddleNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}