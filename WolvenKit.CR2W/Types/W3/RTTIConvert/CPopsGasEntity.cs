using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPopsGasEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("restorationTime")] 		public CFloat RestorationTime { get; set;}

		[Ordinal(2)] [RED("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[Ordinal(3)] [RED("fxOnSpawn")] 		public CName FxOnSpawn { get; set;}

		[Ordinal(4)] [RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[Ordinal(5)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(6)] [RED("settled")] 		public CBool Settled { get; set;}

		[Ordinal(7)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(8)] [RED("victims", 2,0)] 		public CArray<CHandle<CActor>> Victims { get; set;}

		[Ordinal(9)] [RED("poisonArea")] 		public CHandle<CTriggerAreaComponent> PoisonArea { get; set;}

		[Ordinal(10)] [RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		public CPopsGasEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPopsGasEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}