using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Burning : W3CriticalDOTEffect
	{
		[Ordinal(1)] [RED("("cachedMPAC")] 		public CHandle<CMovingPhysicalAgentComponent> CachedMPAC { get; set;}

		[Ordinal(2)] [RED("("glyphword12Delay")] 		public CFloat Glyphword12Delay { get; set;}

		[Ordinal(3)] [RED("("isWithGlyphword12")] 		public CBool IsWithGlyphword12 { get; set;}

		[Ordinal(4)] [RED("("glyphword12Fx")] 		public CHandle<W3VisualFx> Glyphword12Fx { get; set;}

		[Ordinal(5)] [RED("("glyphword12BurningChance")] 		public CFloat Glyphword12BurningChance { get; set;}

		[Ordinal(6)] [RED("("glyphword12NotBurnedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> Glyphword12NotBurnedEntities { get; set;}

		public W3Effect_Burning(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Burning(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}