using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGroupFXManager : CGameplayEntity
	{
		[Ordinal(1)] [RED("("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(2)] [RED("("randomDropMin")] 		public CFloat RandomDropMin { get; set;}

		[Ordinal(3)] [RED("("randomDropMax")] 		public CFloat RandomDropMax { get; set;}

		[Ordinal(4)] [RED("("effectName")] 		public CName EffectName { get; set;}

		[Ordinal(5)] [RED("("ntities", 2,0)] 		public CArray<CHandle<CEntity>> Ntities { get; set;}

		[Ordinal(6)] [RED("("randomDrop")] 		public CFloat RandomDrop { get; set;}

		public CGroupFXManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGroupFXManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}