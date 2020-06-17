using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootParam : CGameplayEntityParam
	{
		[RED("containers", 2,0)] 		public CArray<CR4LootContainerParam> Containers { get; set;}

		[RED("usedContainersMin")] 		public CUInt32 UsedContainersMin { get; set;}

		[RED("usedContainersMax")] 		public CUInt32 UsedContainersMax { get; set;}

		[RED("alwaysPresent")] 		public CBool AlwaysPresent { get; set;}

		public CR4LootParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4LootParam(cr2w);

	}
}