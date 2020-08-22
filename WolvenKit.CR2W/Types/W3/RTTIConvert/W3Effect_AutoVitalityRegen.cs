using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_AutoVitalityRegen : W3AutoRegenEffect
	{
		[RED("regenModeIsCombat")] 		public CBool RegenModeIsCombat { get; set;}

		[RED("cachedPlayer")] 		public CHandle<CR4Player> CachedPlayer { get; set;}

		public W3Effect_AutoVitalityRegen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_AutoVitalityRegen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}