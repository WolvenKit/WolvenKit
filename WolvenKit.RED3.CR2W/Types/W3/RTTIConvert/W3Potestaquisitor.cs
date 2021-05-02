using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potestaquisitor : W3QuestUsableItem
	{
		[Ordinal(1)] [RED("detectableTag")] 		public CName DetectableTag { get; set;}

		[Ordinal(2)] [RED("detectableRange")] 		public CFloat DetectableRange { get; set;}

		[Ordinal(3)] [RED("closestRange")] 		public CFloat ClosestRange { get; set;}

		[Ordinal(4)] [RED("potestaquisitorFact")] 		public CString PotestaquisitorFact { get; set;}

		[Ordinal(5)] [RED("soundEffectType")] 		public CEnum<EFocusModeSoundEffectType> SoundEffectType { get; set;}

		[Ordinal(6)] [RED("effect")] 		public CName Effect { get; set;}

		[Ordinal(7)] [RED("registeredAnomalies", 2,0)] 		public CArray<CHandle<CGameplayEntity>> RegisteredAnomalies { get; set;}

		[Ordinal(8)] [RED("previousClosestAnomaly")] 		public CHandle<CGameplayEntity> PreviousClosestAnomaly { get; set;}

		public W3Potestaquisitor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Potestaquisitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}