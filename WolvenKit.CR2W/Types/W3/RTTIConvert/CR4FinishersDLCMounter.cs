using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4FinishersDLCMounter : IGameplayDLCMounter
	{
		[RED("customCameraAnimSet")] 		public CHandle<CSkeletalAnimationSet> CustomCameraAnimSet { get; set;}

		[RED("finishers", 2,0)] 		public CArray<CPtr<CR4FinisherDLC>> Finishers { get; set;}

		public CR4FinishersDLCMounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4FinishersDLCMounter(cr2w);

	}
}