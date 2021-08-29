using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animActionAnimDatabase_DatabaseRow : RedBaseClass
	{
		private CName _animFeatureName;
		private CInt32 _state;
		private CInt32 _animVariation;
		private animActionAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(3)] 
		[RED("animationData")] 
		public animActionAnimDatabase_AnimationData AnimationData
		{
			get => GetProperty(ref _animationData);
			set => SetProperty(ref _animationData, value);
		}
	}
}
