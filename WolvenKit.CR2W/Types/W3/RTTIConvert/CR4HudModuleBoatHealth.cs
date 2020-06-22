using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBoatHealth : CR4HudModuleBase
	{
		[RED("m_fxSetVolumeHealth")] 		public CHandle<CScriptedFlashFunction> M_fxSetVolumeHealth { get; set;}

		[RED("m_wasInBoat")] 		public CBool M_wasInBoat { get; set;}

		public CR4HudModuleBoatHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleBoatHealth(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}