using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		private CBool _clamp;
		private CBool _resetOnActivation;
		private CBool _normalize180;
		private CFloat _defaultValue;
		private CName _resetExternalEventName;
		private animFloatLink _inputNode;
		private animFloatLink _minValue;
		private animFloatLink _maxValue;
		private animFloatLink _resetSpeed;
		private animBoolLink _override;
		private animFloatLink _curValue;
		private animBoolLink _normalize180Input;

		[Ordinal(11)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get => GetProperty(ref _clamp);
			set => SetProperty(ref _clamp, value);
		}

		[Ordinal(12)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetProperty(ref _resetOnActivation);
			set => SetProperty(ref _resetOnActivation, value);
		}

		[Ordinal(13)] 
		[RED("normalize180")] 
		public CBool Normalize180
		{
			get => GetProperty(ref _normalize180);
			set => SetProperty(ref _normalize180, value);
		}

		[Ordinal(14)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(15)] 
		[RED("resetExternalEventName")] 
		public CName ResetExternalEventName
		{
			get => GetProperty(ref _resetExternalEventName);
			set => SetProperty(ref _resetExternalEventName, value);
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(17)] 
		[RED("minValue")] 
		public animFloatLink MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(18)] 
		[RED("maxValue")] 
		public animFloatLink MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(19)] 
		[RED("resetSpeed")] 
		public animFloatLink ResetSpeed
		{
			get => GetProperty(ref _resetSpeed);
			set => SetProperty(ref _resetSpeed, value);
		}

		[Ordinal(20)] 
		[RED("override")] 
		public animBoolLink Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(21)] 
		[RED("curValue")] 
		public animFloatLink CurValue
		{
			get => GetProperty(ref _curValue);
			set => SetProperty(ref _curValue, value);
		}

		[Ordinal(22)] 
		[RED("normalize180Input")] 
		public animBoolLink Normalize180Input
		{
			get => GetProperty(ref _normalize180Input);
			set => SetProperty(ref _normalize180Input, value);
		}
	}
}
