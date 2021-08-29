using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsclothClothCapsuleExportData : ISerializable
	{
		private CArray<physicsclothExportedCapsule> _capsules;

		[Ordinal(0)] 
		[RED("capsules")] 
		public CArray<physicsclothExportedCapsule> Capsules
		{
			get => GetProperty(ref _capsules);
			set => SetProperty(ref _capsules, value);
		}
	}
}
