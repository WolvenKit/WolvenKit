using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GameEffectManager : CObject
	{
		[Ordinal(1)] [RED("effects", 2,0)] 		public CArray<CHandle<CBaseGameplayEffect>> Effects { get; set;}

		[Ordinal(2)] [RED("effectNames", 2,0)] 		public CArray<CName> EffectNames { get; set;}

		[Ordinal(3)] [RED("isReady")] 		public CBool IsReady { get; set;}

		[Ordinal(4)] [RED("effectIconTypes", 2,0)] 		public CArray<SEffectIconType> EffectIconTypes { get; set;}

		public W3GameEffectManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GameEffectManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}