using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4FinishersDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("customCameraAnimSet")] 		public CHandle<CSkeletalAnimationSet> CustomCameraAnimSet { get; set;}

		[Ordinal(2)] [RED("finishers", 2,0)] 		public CArray<CPtr<CR4FinisherDLC>> Finishers { get; set;}

		public CR4FinishersDLCMounter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4FinishersDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}