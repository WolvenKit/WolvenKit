using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructionData : RedBaseClass
	{
		private CEnum<EDeviceDurabilityType> _durabilityType;
		private CBool _canBeFixed;

		[Ordinal(0)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetProperty(ref _durabilityType);
			set => SetProperty(ref _durabilityType, value);
		}

		[Ordinal(1)] 
		[RED("canBeFixed")] 
		public CBool CanBeFixed
		{
			get => GetProperty(ref _canBeFixed);
			set => SetProperty(ref _canBeFixed, value);
		}
	}
}
