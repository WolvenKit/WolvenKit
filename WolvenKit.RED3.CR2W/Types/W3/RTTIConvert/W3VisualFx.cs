using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VisualFx : CEntity
	{
		[Ordinal(1)] [RED("effectName")] 		public CName EffectName { get; set;}

		[Ordinal(2)] [RED("destroyEffectTime")] 		public CFloat DestroyEffectTime { get; set;}

		[Ordinal(3)] [RED("timedFxDestroyName")] 		public CName TimedFxDestroyName { get; set;}

		[Ordinal(4)] [RED("parentActorHandle")] 		public EntityHandle ParentActorHandle { get; set;}

		public W3VisualFx(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VisualFx(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}