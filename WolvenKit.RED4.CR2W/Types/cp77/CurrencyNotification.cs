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
		private CHandle<CurrencyUpdateNotificationViewData> _currencyData;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;

		[Ordinal(12)] 
		[RED("CurrencyUpdateAnimation")] 
		public CName CurrencyUpdateAnimation
		{
			get
			{
				if (_currencyUpdateAnimation == null)
				{
					_currencyUpdateAnimation = (CName) CR2WTypeManager.Create("CName", "CurrencyUpdateAnimation", cr2w, this);
				}
				return _currencyUpdateAnimation;
			}
			set
			{
				if (_currencyUpdateAnimation == value)
				{
					return;
				}
				_currencyUpdateAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("CurrencyDiff")] 
		public inkTextWidgetReference CurrencyDiff
		{
			get
			{
				if (_currencyDiff == null)
				{
					_currencyDiff = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CurrencyDiff", cr2w, this);
				}
				return _currencyDiff;
			}
			set
			{
				if (_currencyDiff == value)
				{
					return;
				}
				_currencyDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("CurrencyTotal")] 
		public inkTextWidgetReference CurrencyTotal
		{
			get
			{
				if (_currencyTotal == null)
				{
					_currencyTotal = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CurrencyTotal", cr2w, this);
				}
				return _currencyTotal;
			}
			set
			{
				if (_currencyTotal == value)
				{
					return;
				}
				_currencyTotal = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("diff_animator")] 
		public CHandle<inkTextValueProgressAnimationController> Diff_animator
		{
			get
			{
				if (_diff_animator == null)
				{
					_diff_animator = (CHandle<inkTextValueProgressAnimationController>) CR2WTypeManager.Create("handle:inkTextValueProgressAnimationController", "diff_animator", cr2w, this);
				}
				return _diff_animator;
			}
			set
			{
				if (_diff_animator == value)
				{
					return;
				}
				_diff_animator = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("total_animator")] 
		public CHandle<inkTextValueProgressAnimationController> Total_animator
		{
			get
			{
				if (_total_animator == null)
				{
					_total_animator = (CHandle<inkTextValueProgressAnimationController>) CR2WTypeManager.Create("handle:inkTextValueProgressAnimationController", "total_animator", cr2w, this);
				}
				return _total_animator;
			}
			set
			{
				if (_total_animator == value)
				{
					return;
				}
				_total_animator = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currencyData")] 
		public CHandle<CurrencyUpdateNotificationViewData> CurrencyData
		{
			get
			{
				if (_currencyData == null)
				{
					_currencyData = (CHandle<CurrencyUpdateNotificationViewData>) CR2WTypeManager.Create("handle:CurrencyUpdateNotificationViewData", "currencyData", cr2w, this);
				}
				return _currencyData;
			}
			set
			{
				if (_currencyData == value)
				{
					return;
				}
				_currencyData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get
			{
				if (_uiSystemBB == null)
				{
					_uiSystemBB = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "uiSystemBB", cr2w, this);
				}
				return _uiSystemBB;
			}
			set
			{
				if (_uiSystemBB == value)
				{
					return;
				}
				_uiSystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get
			{
				if (_uiSystemId == null)
				{
					_uiSystemId = (CUInt32) CR2WTypeManager.Create("Uint32", "uiSystemId", cr2w, this);
				}
				return _uiSystemId;
			}
			set
			{
				if (_uiSystemId == value)
				{
					return;
				}
				_uiSystemId = value;
				PropertySet(this);
			}
		}

		public CurrencyNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
