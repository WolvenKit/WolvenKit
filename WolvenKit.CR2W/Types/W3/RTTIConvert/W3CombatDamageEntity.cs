using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CombatDamageEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("victims", 2,0)] 		public CArray<CHandle<CActor>> Victims { get; set;}

		[Ordinal(2)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(3)] [RED("isActive")] 		public CBool IsActive { get; set;}

		public W3CombatDamageEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CombatDamageEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}