using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChangeIdleAnimEvent : scnPlayAnimEvent
	{
		private CName _idleAnimName;
		private CName _addIdleAnimName;
		private CBool _isEnabled;
		private CName _animName;
		private animFacialEmotionTransitionBaked _bakedFacialTransition;
		private CBool _facialInstantTransition;

		[Ordinal(15)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get => GetProperty(ref _idleAnimName);
			set => SetProperty(ref _idleAnimName, value);
		}

		[Ordinal(16)] 
		[RED("addIdleAnimName")] 
		public CName AddIdleAnimName
		{
			get => GetProperty(ref _addIdleAnimName);
			set => SetProperty(ref _addIdleAnimName, value);
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(18)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(19)] 
		[RED("bakedFacialTransition")] 
		public animFacialEmotionTransitionBaked BakedFacialTransition
		{
			get => GetProperty(ref _bakedFacialTransition);
			set => SetProperty(ref _bakedFacialTransition, value);
		}

		[Ordinal(20)] 
		[RED("facialInstantTransition")] 
		public CBool FacialInstantTransition
		{
			get => GetProperty(ref _facialInstantTransition);
			set => SetProperty(ref _facialInstantTransition, value);
		}
	}
}
