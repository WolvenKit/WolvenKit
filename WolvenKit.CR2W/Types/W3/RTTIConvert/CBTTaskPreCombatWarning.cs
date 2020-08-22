using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPreCombatWarning : IBehTreeTask
	{
		[RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		[RED("setFlagOnActivate")] 		public CBool SetFlagOnActivate { get; set;}

		[RED("setFlagOnDectivate")] 		public CBool SetFlagOnDectivate { get; set;}

		[RED("flag")] 		public CBool Flag { get; set;}

		public CBTTaskPreCombatWarning(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPreCombatWarning(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}