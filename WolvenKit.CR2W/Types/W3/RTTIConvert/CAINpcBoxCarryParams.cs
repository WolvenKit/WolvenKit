using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcBoxCarryParams : CAINpcIdleParams
	{
		[RED("workCarryItemTemplate")] 		public CHandle<CEntityTemplate> WorkCarryItemTemplate { get; set;}

		[RED("workCarryPickupPoint")] 		public CName WorkCarryPickupPoint { get; set;}

		[RED("workCarryDropPoint")] 		public CName WorkCarryDropPoint { get; set;}

		public CAINpcBoxCarryParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAINpcBoxCarryParams(cr2w);

	}
}