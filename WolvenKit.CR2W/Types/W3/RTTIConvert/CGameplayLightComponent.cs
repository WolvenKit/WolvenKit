using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayLightComponent : CInteractionComponent
	{
		[Ordinal(1)] [RED("isLightOn")] 		public CBool IsLightOn { get; set;}

		[Ordinal(2)] [RED("isCityLight")] 		public CBool IsCityLight { get; set;}

		[Ordinal(3)] [RED("isInteractive")] 		public CBool IsInteractive { get; set;}

		[Ordinal(4)] [RED("isAffectedByWeather")] 		public CBool IsAffectedByWeather { get; set;}

		[Ordinal(5)] [RED("factOnIgnite")] 		public CName FactOnIgnite { get; set;}

		[Ordinal(6)] [RED("actionBlockingExceptions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> ActionBlockingExceptions { get; set;}

		[Ordinal(7)] [RED("restoreItemLAtEnd")] 		public CBool RestoreItemLAtEnd { get; set;}

		public CGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameplayLightComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}