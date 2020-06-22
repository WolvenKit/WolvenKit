using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPopsGasEntity : CInteractiveEntity
	{
		[RED("restorationTime")] 		public CFloat RestorationTime { get; set;}

		[RED("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[RED("fxOnSpawn")] 		public CName FxOnSpawn { get; set;}

		[RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[RED("i")] 		public CInt32 I { get; set;}

		[RED("settled")] 		public CBool Settled { get; set;}

		[RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[RED("victims", 2,0)] 		public CArray<CHandle<CActor>> Victims { get; set;}

		[RED("poisonArea")] 		public CHandle<CTriggerAreaComponent> PoisonArea { get; set;}

		[RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		public CPopsGasEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPopsGasEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}