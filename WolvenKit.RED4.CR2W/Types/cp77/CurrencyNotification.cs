using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyNotification : GenericNotificationController
	{
		private CName _currencyUpdateAnimation;
		private inkTextWidgetReference _currencyDiff;
		private inkTextWidgetReference _currencyTotal;
		private CHandle<inkTextValueProgressAnimationController> _diff_animator;
		private CHandle<inkTextValueProgressAnimationController> _total_animator;
		private CHandle<gameuiCurrencyUpdateNotificationViewData> _currencyData;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;

		[Ordinal(12)] 
		[RED("CurrencyUpdateAnimation")] 
		public CName CurrencyUpdateAnimation
		{
			get => GetProperty(ref _currencyUpdateAnimation);
			set => SetProperty(ref _currencyUpdateAnimation, value);
		}

		[Ordinal(13)] 
		[RED("CurrencyDiff")] 
		public inkTextWidgetReference CurrencyDiff
		{
			get => GetProperty(ref _currencyDiff);
			set => SetProperty(ref _currencyDiff, value);
		}

		[Ordinal(14)] 
		[RED("CurrencyTotal")] 
		public inkTextWidgetReference CurrencyTotal
		{
			get => GetProperty(ref _currencyTotal);
			set => SetProperty(ref _currencyTotal, value);
		}

		[Ordinal(15)] 
		[RED("diff_animator")] 
		public CHandle<inkTextValueProgressAnimationController> Diff_animator
		{
			get => GetProperty(ref _diff_animator);
			set => SetProperty(ref _diff_animator, value);
		}

		[Ordinal(16)] 
		[RED("total_animator")] 
		public CHandle<inkTextValueProgressAnimationController> Total_animator
		{
			get => GetProperty(ref _total_animator);
			set => SetProperty(ref _total_animator, value);
		}

		[Ordinal(17)] 
		[RED("currencyData")] 
		public CHandle<gameuiCurrencyUpdateNotificationViewData> CurrencyData
		{
			get => GetProperty(ref _currencyData);
			set => SetProperty(ref _currencyData, value);
		}

		[Ordinal(18)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(19)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(20)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(21)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		public CurrencyNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
