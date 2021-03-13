using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimProjectileEvent : CExtAnimEvent
	{
		[Ordinal(1)] [RED("spell")] 		public CHandle<CEntityTemplate> Spell { get; set;}

		[Ordinal(2)] [RED("castPosition")] 		public CEnum<EProjectileCastPosition> CastPosition { get; set;}

		[Ordinal(3)] [RED("boneName")] 		public CName BoneName { get; set;}

		public CExtAnimProjectileEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimProjectileEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}