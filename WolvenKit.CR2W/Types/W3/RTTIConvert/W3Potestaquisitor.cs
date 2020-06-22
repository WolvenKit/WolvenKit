using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potestaquisitor : W3QuestUsableItem
	{
		[RED("detectableTag")] 		public CName DetectableTag { get; set;}

		[RED("detectableRange")] 		public CFloat DetectableRange { get; set;}

		[RED("closestRange")] 		public CFloat ClosestRange { get; set;}

		[RED("potestaquisitorFact")] 		public CString PotestaquisitorFact { get; set;}

		[RED("soundEffectType")] 		public CEnum<EFocusModeSoundEffectType> SoundEffectType { get; set;}

		[RED("effect")] 		public CName Effect { get; set;}

		[RED("registeredAnomalies", 2,0)] 		public CArray<CHandle<CGameplayEntity>> RegisteredAnomalies { get; set;}

		[RED("previousClosestAnomaly")] 		public CHandle<CGameplayEntity> PreviousClosestAnomaly { get; set;}

		public W3Potestaquisitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Potestaquisitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}