using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayLightComponent : CInteractionComponent
	{
		[RED("isLightOn")] 		public CBool IsLightOn { get; set;}

		[RED("isCityLight")] 		public CBool IsCityLight { get; set;}

		[RED("isInteractive")] 		public CBool IsInteractive { get; set;}

		[RED("isAffectedByWeather")] 		public CBool IsAffectedByWeather { get; set;}

		[RED("factOnIgnite")] 		public CName FactOnIgnite { get; set;}

		public CGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameplayLightComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}