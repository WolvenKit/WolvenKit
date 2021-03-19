using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Smart_Rifl_Bucket : inkWidgetLogicController
	{
		private inkWidgetReference _progressBar;
		private inkWidgetReference _progressBarValue;
		private inkWidgetReference _targetIndicator;
		private inkWidgetReference _lockedIndicator;
		private inkWidgetReference _lockingIndicator;
		private gamesmartGunUITargetParameters _data;
		private CHandle<inkanimProxy> _lockingAnimationProxy;

		[Ordinal(1)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(2)] 
		[RED("progressBarValue")] 
		public inkWidgetReference ProgressBarValue
		{
			get => GetProperty(ref _progressBarValue);
			set => SetProperty(ref _progressBarValue, value);
		}

		[Ordinal(3)] 
		[RED("targetIndicator")] 
		public inkWidgetReference TargetIndicator
		{
			get => GetProperty(ref _targetIndicator);
			set => SetProperty(ref _targetIndicator, value);
		}

		[Ordinal(4)] 
		[RED("lockedIndicator")] 
		public inkWidgetReference LockedIndicator
		{
			get => GetProperty(ref _lockedIndicator);
			set => SetProperty(ref _lockedIndicator, value);
		}

		[Ordinal(5)] 
		[RED("lockingIndicator")] 
		public inkWidgetReference LockingIndicator
		{
			get => GetProperty(ref _lockingIndicator);
			set => SetProperty(ref _lockingIndicator, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(7)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetProperty(ref _lockingAnimationProxy);
			set => SetProperty(ref _lockingAnimationProxy, value);
		}

		public Crosshair_Smart_Rifl_Bucket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
