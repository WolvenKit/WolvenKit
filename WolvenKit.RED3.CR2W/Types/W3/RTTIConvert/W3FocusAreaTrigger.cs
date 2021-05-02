using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FocusAreaTrigger : CGameplayEntity
	{
		[Ordinal(1)] [RED("rumbleIntensityModifier")] 		public CFloat RumbleIntensityModifier { get; set;}

		[Ordinal(2)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(3)] [RED("intensity")] 		public CFloat Intensity { get; set;}

		[Ordinal(4)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(5)] [RED("linkedClues", 2,0)] 		public CArray<EntityHandle> LinkedClues { get; set;}

		[Ordinal(6)] [RED("linkedCluesTags", 2,0)] 		public CArray<CName> LinkedCluesTags { get; set;}

		public W3FocusAreaTrigger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}