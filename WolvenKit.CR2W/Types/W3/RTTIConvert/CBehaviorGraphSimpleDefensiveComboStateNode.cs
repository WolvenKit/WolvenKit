using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSimpleDefensiveComboStateNode : CBehaviorGraphComboStateNode
	{
		[RED("varHitTime")] 		public CName VarHitTime { get; set;}

		[RED("varHitLevel")] 		public CName VarHitLevel { get; set;}

		[RED("varElemEnum")] 		public CName VarElemEnum { get; set;}

		[RED("varParry")] 		public CName VarParry { get; set;}

		[RED("enum")] 		public CName Enum { get; set;}

		[RED("animElems", 2,0)] 		public CArray<SBehaviorComboElem> AnimElems { get; set;}

		public CBehaviorGraphSimpleDefensiveComboStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSimpleDefensiveComboStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}