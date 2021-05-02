using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcBoxCarryParams : CAINpcIdleParams
	{
		[Ordinal(1)] [RED("workCarryItemTemplate")] 		public CHandle<CEntityTemplate> WorkCarryItemTemplate { get; set;}

		[Ordinal(2)] [RED("workCarryPickupPoint")] 		public CName WorkCarryPickupPoint { get; set;}

		[Ordinal(3)] [RED("workCarryDropPoint")] 		public CName WorkCarryDropPoint { get; set;}

		public CAINpcBoxCarryParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}