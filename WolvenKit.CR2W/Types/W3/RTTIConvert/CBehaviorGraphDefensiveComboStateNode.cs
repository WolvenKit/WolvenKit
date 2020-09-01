using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDefensiveComboStateNode : CBehaviorGraphComboStateNode
	{
		[Ordinal(0)] [RED("("varHitTime")] 		public CName VarHitTime { get; set;}

		[Ordinal(0)] [RED("("varLevel")] 		public CName VarLevel { get; set;}

		[Ordinal(0)] [RED("("varParry")] 		public CName VarParry { get; set;}

		[Ordinal(0)] [RED("("defaultHits", 2,0)] 		public CArray<CName> DefaultHits { get; set;}

		public CBehaviorGraphDefensiveComboStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphDefensiveComboStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}