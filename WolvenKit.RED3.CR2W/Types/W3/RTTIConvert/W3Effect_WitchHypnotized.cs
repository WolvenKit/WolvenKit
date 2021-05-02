using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_WitchHypnotized : W3CriticalEffect
	{
		[Ordinal(1)] [RED("customCameraStackIndex")] 		public CInt32 CustomCameraStackIndex { get; set;}

		[Ordinal(2)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(3)] [RED("envID")] 		public CInt32 EnvID { get; set;}

		public W3Effect_WitchHypnotized(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}