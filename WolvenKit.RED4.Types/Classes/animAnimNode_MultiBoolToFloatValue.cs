using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		private CBool _allMustBeTrue;
		private CFloat _onTrue;
		private CFloat _onFalse;
		private CArray<animAnimMultiBoolToFloatEntry> _inputsData;

		[Ordinal(11)] 
		[RED("allMustBeTrue")] 
		public CBool AllMustBeTrue
		{
			get => GetProperty(ref _allMustBeTrue);
			set => SetProperty(ref _allMustBeTrue, value);
		}

		[Ordinal(12)] 
		[RED("onTrue")] 
		public CFloat OnTrue
		{
			get => GetProperty(ref _onTrue);
			set => SetProperty(ref _onTrue, value);
		}

		[Ordinal(13)] 
		[RED("onFalse")] 
		public CFloat OnFalse
		{
			get => GetProperty(ref _onFalse);
			set => SetProperty(ref _onFalse, value);
		}

		[Ordinal(14)] 
		[RED("inputsData")] 
		public CArray<animAnimMultiBoolToFloatEntry> InputsData
		{
			get => GetProperty(ref _inputsData);
			set => SetProperty(ref _inputsData, value);
		}

		public animAnimNode_MultiBoolToFloatValue()
		{
			_onTrue = 1.000000F;
		}
	}
}
