using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInventoryItemUIData : CVariable
	{
		[Ordinal(1)] [RED("gridPosition")] 		public CInt32 GridPosition { get; set;}

		[Ordinal(2)] [RED("gridSize")] 		public CInt32 GridSize { get; set;}

		[Ordinal(3)] [RED("isNew")] 		public CBool IsNew { get; set;}

		public SInventoryItemUIData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}