using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTriggerAreaEnvironmentVisibilityComponent : CTriggerAreaComponent
	{
		[RED("hideTerrain")] 		public CBool HideTerrain { get; set;}

		[RED("hideFoliage")] 		public CBool HideFoliage { get; set;}

		[RED("hideWater")] 		public CBool HideWater { get; set;}

		public CTriggerAreaEnvironmentVisibilityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTriggerAreaEnvironmentVisibilityComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}