using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleAreaInfo : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetTextSFF { get; set;}

		[Ordinal(2)] [RED("dt")] 		public CFloat Dt { get; set;}

		[Ordinal(3)] [RED("showTime")] 		public CFloat ShowTime { get; set;}

		[Ordinal(4)] [RED("bShow")] 		public CBool BShow { get; set;}

		public CR4HudModuleAreaInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleAreaInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}