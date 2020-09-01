using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateUnconscious : CR4PlayerStateExtendedMovable
	{
		[Ordinal(0)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("isUnconscious")] 		public CBool IsUnconscious { get; set;}

		[Ordinal(0)] [RED("killedByGuard")] 		public CBool KilledByGuard { get; set;}

		[Ordinal(0)] [RED("killedByElevator")] 		public CBool KilledByElevator { get; set;}

		[Ordinal(0)] [RED("wasInFFMiniGame")] 		public CBool WasInFFMiniGame { get; set;}

		[Ordinal(0)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		[Ordinal(0)] [RED("cachedID")] 		public SItemUniqueId CachedID { get; set;}

		[Ordinal(0)] [RED("itemEnt1")] 		public CHandle<CEntity> ItemEnt1 { get; set;}

		[Ordinal(0)] [RED("itemEnt2")] 		public CHandle<CEntity> ItemEnt2 { get; set;}

		public CR4PlayerStateUnconscious(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateUnconscious(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}