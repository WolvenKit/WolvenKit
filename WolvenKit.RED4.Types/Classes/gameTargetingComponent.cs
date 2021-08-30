using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTargetingComponent : entIPlacedComponent
	{
		private CBool _isPrimary;
		private CBool _isDirectional;
		private CArray<TweakDBID> _aimAssistData;
		private CBool _isEnabled;
		private CBool _alwaysInTestRange;

		[Ordinal(5)] 
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get => GetProperty(ref _isPrimary);
			set => SetProperty(ref _isPrimary, value);
		}

		[Ordinal(6)] 
		[RED("isDirectional")] 
		public CBool IsDirectional
		{
			get => GetProperty(ref _isDirectional);
			set => SetProperty(ref _isDirectional, value);
		}

		[Ordinal(7)] 
		[RED("aimAssistData")] 
		public CArray<TweakDBID> AimAssistData
		{
			get => GetProperty(ref _aimAssistData);
			set => SetProperty(ref _aimAssistData, value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(9)] 
		[RED("alwaysInTestRange")] 
		public CBool AlwaysInTestRange
		{
			get => GetProperty(ref _alwaysInTestRange);
			set => SetProperty(ref _alwaysInTestRange, value);
		}

		public gameTargetingComponent()
		{
			_isPrimary = true;
			_isEnabled = true;
		}
	}
}
