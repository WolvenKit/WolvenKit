using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBoatHealth : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetVolumeHealth")] 		public CHandle<CScriptedFlashFunction> M_fxSetVolumeHealth { get; set;}

		[Ordinal(2)] [RED("m_wasInBoat")] 		public CBool M_wasInBoat { get; set;}

		public CR4HudModuleBoatHealth(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}