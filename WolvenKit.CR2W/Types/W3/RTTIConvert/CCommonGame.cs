using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommonGame : CGame
	{
		[Ordinal(0)] [RED("player")] 		public CHandle<CPlayer> Player { get; set;}

		[Ordinal(0)] [RED("dlcManager")] 		public CPtr<CDLCManager> DlcManager { get; set;}

		[Ordinal(0)] [RED("tooltipSettings")] 		public CHandle<C2dArray> TooltipSettings { get; set;}

		public CCommonGame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCommonGame(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}