using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerData : RedBaseClass
	{
		private CName _name;
		private CUInt32 _variationIndex;
		private CUInt32 _variationNumber;
		private CEnum<locVoiceoverContext> _overridingVoContext;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("variationIndex")] 
		public CUInt32 VariationIndex
		{
			get => GetProperty(ref _variationIndex);
			set => SetProperty(ref _variationIndex, value);
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get => GetProperty(ref _variationNumber);
			set => SetProperty(ref _variationNumber, value);
		}

		[Ordinal(3)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetProperty(ref _overridingVoContext);
			set => SetProperty(ref _overridingVoContext, value);
		}
	}
}
