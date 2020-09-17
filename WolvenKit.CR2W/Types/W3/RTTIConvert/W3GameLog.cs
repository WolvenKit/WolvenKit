using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GameLog : CObject
	{
		[Ordinal(1)] [RED("COLOR_GOLD_BEGIN")] 		public CString COLOR_GOLD_BEGIN { get; set;}

		[Ordinal(2)] [RED("COLOR_GOLD_END")] 		public CString COLOR_GOLD_END { get; set;}

		[Ordinal(3)] [RED("cachedCombatMessages", 2,0)] 		public CArray<SCachedCombatMessage> CachedCombatMessages { get; set;}

		public W3GameLog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GameLog(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}