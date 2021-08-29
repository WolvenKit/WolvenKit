using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _lifeIcon;
		private inkImageWidgetReference _checkIcon;
		private inkImageWidgetReference _genericIcon;
		private inkImageWidgetReference _payIcon;
		private inkCompoundWidgetReference _lifeHolder;
		private inkCompoundWidgetReference _checkHolder;
		private inkCompoundWidgetReference _genericHolder;
		private inkCompoundWidgetReference _payHolder;
		private inkTextWidgetReference _lifeDescriptionText;
		private inkTextWidgetReference _checkText;
		private inkTextWidgetReference _payText;
		private inkWidgetReference _lifeBackground;
		private inkWidgetReference _lifeBackgroundFail;
		private inkWidgetReference _checkBackground;
		private inkWidgetReference _checkBackgroundFail;
		private inkWidgetReference _payBackground;
		private inkWidgetReference _payBackgroundFail;

		[Ordinal(1)] 
		[RED("LifeIcon")] 
		public inkImageWidgetReference LifeIcon
		{
			get => GetProperty(ref _lifeIcon);
			set => SetProperty(ref _lifeIcon, value);
		}

		[Ordinal(2)] 
		[RED("CheckIcon")] 
		public inkImageWidgetReference CheckIcon
		{
			get => GetProperty(ref _checkIcon);
			set => SetProperty(ref _checkIcon, value);
		}

		[Ordinal(3)] 
		[RED("GenericIcon")] 
		public inkImageWidgetReference GenericIcon
		{
			get => GetProperty(ref _genericIcon);
			set => SetProperty(ref _genericIcon, value);
		}

		[Ordinal(4)] 
		[RED("PayIcon")] 
		public inkImageWidgetReference PayIcon
		{
			get => GetProperty(ref _payIcon);
			set => SetProperty(ref _payIcon, value);
		}

		[Ordinal(5)] 
		[RED("LifeHolder")] 
		public inkCompoundWidgetReference LifeHolder
		{
			get => GetProperty(ref _lifeHolder);
			set => SetProperty(ref _lifeHolder, value);
		}

		[Ordinal(6)] 
		[RED("CheckHolder")] 
		public inkCompoundWidgetReference CheckHolder
		{
			get => GetProperty(ref _checkHolder);
			set => SetProperty(ref _checkHolder, value);
		}

		[Ordinal(7)] 
		[RED("GenericHolder")] 
		public inkCompoundWidgetReference GenericHolder
		{
			get => GetProperty(ref _genericHolder);
			set => SetProperty(ref _genericHolder, value);
		}

		[Ordinal(8)] 
		[RED("PayHolder")] 
		public inkCompoundWidgetReference PayHolder
		{
			get => GetProperty(ref _payHolder);
			set => SetProperty(ref _payHolder, value);
		}

		[Ordinal(9)] 
		[RED("LifeDescriptionText")] 
		public inkTextWidgetReference LifeDescriptionText
		{
			get => GetProperty(ref _lifeDescriptionText);
			set => SetProperty(ref _lifeDescriptionText, value);
		}

		[Ordinal(10)] 
		[RED("CheckText")] 
		public inkTextWidgetReference CheckText
		{
			get => GetProperty(ref _checkText);
			set => SetProperty(ref _checkText, value);
		}

		[Ordinal(11)] 
		[RED("PayText")] 
		public inkTextWidgetReference PayText
		{
			get => GetProperty(ref _payText);
			set => SetProperty(ref _payText, value);
		}

		[Ordinal(12)] 
		[RED("LifeBackground")] 
		public inkWidgetReference LifeBackground
		{
			get => GetProperty(ref _lifeBackground);
			set => SetProperty(ref _lifeBackground, value);
		}

		[Ordinal(13)] 
		[RED("LifeBackgroundFail")] 
		public inkWidgetReference LifeBackgroundFail
		{
			get => GetProperty(ref _lifeBackgroundFail);
			set => SetProperty(ref _lifeBackgroundFail, value);
		}

		[Ordinal(14)] 
		[RED("CheckBackground")] 
		public inkWidgetReference CheckBackground
		{
			get => GetProperty(ref _checkBackground);
			set => SetProperty(ref _checkBackground, value);
		}

		[Ordinal(15)] 
		[RED("CheckBackgroundFail")] 
		public inkWidgetReference CheckBackgroundFail
		{
			get => GetProperty(ref _checkBackgroundFail);
			set => SetProperty(ref _checkBackgroundFail, value);
		}

		[Ordinal(16)] 
		[RED("PayBackground")] 
		public inkWidgetReference PayBackground
		{
			get => GetProperty(ref _payBackground);
			set => SetProperty(ref _payBackground, value);
		}

		[Ordinal(17)] 
		[RED("PayBackgroundFail")] 
		public inkWidgetReference PayBackgroundFail
		{
			get => GetProperty(ref _payBackgroundFail);
			set => SetProperty(ref _payBackgroundFail, value);
		}
	}
}
