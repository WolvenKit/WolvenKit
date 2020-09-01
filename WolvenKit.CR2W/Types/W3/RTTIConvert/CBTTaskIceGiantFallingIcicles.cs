using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskIceGiantFallingIcicles : CBTTaskAttack
	{
		[Ordinal(1)] [RED("icicles", 2,0)] 		public CArray<CHandle<CGameplayEntity>> Icicles { get; set;}

		[Ordinal(2)] [RED("rangeForIcyclesActivation")] 		public CFloat RangeForIcyclesActivation { get; set;}

		[Ordinal(3)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskIceGiantFallingIcicles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskIceGiantFallingIcicles(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}