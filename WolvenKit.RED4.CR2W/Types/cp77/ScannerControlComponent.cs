using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerControlComponent : gameScriptableComponent
	{
		private CEnum<MechanicalScanType> _currentScanType;
		private CHandle<gameEffectInstance> _currentScanEffect;
		private CName _currentScanAnimation;
		private CName _scannerTriggerComponentName;
		private CHandle<entIComponent> _scannerTriggerComponent;
		private CHandle<gameStaticTriggerAreaComponent> _a;
		private CBool _isScanningPlayer;

		[Ordinal(5)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get
			{
				if (_currentScanType == null)
				{
					_currentScanType = (CEnum<MechanicalScanType>) CR2WTypeManager.Create("MechanicalScanType", "currentScanType", cr2w, this);
				}
				return _currentScanType;
			}
			set
			{
				if (_currentScanType == value)
				{
					return;
				}
				_currentScanType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get
			{
				if (_currentScanEffect == null)
				{
					_currentScanEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "currentScanEffect", cr2w, this);
				}
				return _currentScanEffect;
			}
			set
			{
				if (_currentScanEffect == value)
				{
					return;
				}
				_currentScanEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get
			{
				if (_currentScanAnimation == null)
				{
					_currentScanAnimation = (CName) CR2WTypeManager.Create("CName", "currentScanAnimation", cr2w, this);
				}
				return _currentScanAnimation;
			}
			set
			{
				if (_currentScanAnimation == value)
				{
					return;
				}
				_currentScanAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("scannerTriggerComponentName")] 
		public CName ScannerTriggerComponentName
		{
			get
			{
				if (_scannerTriggerComponentName == null)
				{
					_scannerTriggerComponentName = (CName) CR2WTypeManager.Create("CName", "scannerTriggerComponentName", cr2w, this);
				}
				return _scannerTriggerComponentName;
			}
			set
			{
				if (_scannerTriggerComponentName == value)
				{
					return;
				}
				_scannerTriggerComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("scannerTriggerComponent")] 
		public CHandle<entIComponent> ScannerTriggerComponent
		{
			get
			{
				if (_scannerTriggerComponent == null)
				{
					_scannerTriggerComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "scannerTriggerComponent", cr2w, this);
				}
				return _scannerTriggerComponent;
			}
			set
			{
				if (_scannerTriggerComponent == value)
				{
					return;
				}
				_scannerTriggerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("a")] 
		public CHandle<gameStaticTriggerAreaComponent> A
		{
			get
			{
				if (_a == null)
				{
					_a = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "a", cr2w, this);
				}
				return _a;
			}
			set
			{
				if (_a == value)
				{
					return;
				}
				_a = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isScanningPlayer")] 
		public CBool IsScanningPlayer
		{
			get
			{
				if (_isScanningPlayer == null)
				{
					_isScanningPlayer = (CBool) CR2WTypeManager.Create("Bool", "isScanningPlayer", cr2w, this);
				}
				return _isScanningPlayer;
			}
			set
			{
				if (_isScanningPlayer == value)
				{
					return;
				}
				_isScanningPlayer = value;
				PropertySet(this);
			}
		}

		public ScannerControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
