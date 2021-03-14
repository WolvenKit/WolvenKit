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
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("progressBarValue")] 
		public inkWidgetReference ProgressBarValue
		{
			get
			{
				if (_progressBarValue == null)
				{
					_progressBarValue = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarValue", cr2w, this);
				}
				return _progressBarValue;
			}
			set
			{
				if (_progressBarValue == value)
				{
					return;
				}
				_progressBarValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetIndicator")] 
		public inkWidgetReference TargetIndicator
		{
			get
			{
				if (_targetIndicator == null)
				{
					_targetIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetIndicator", cr2w, this);
				}
				return _targetIndicator;
			}
			set
			{
				if (_targetIndicator == value)
				{
					return;
				}
				_targetIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lockedIndicator")] 
		public inkWidgetReference LockedIndicator
		{
			get
			{
				if (_lockedIndicator == null)
				{
					_lockedIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lockedIndicator", cr2w, this);
				}
				return _lockedIndicator;
			}
			set
			{
				if (_lockedIndicator == value)
				{
					return;
				}
				_lockedIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lockingIndicator")] 
		public inkWidgetReference LockingIndicator
		{
			get
			{
				if (_lockingIndicator == null)
				{
					_lockingIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lockingIndicator", cr2w, this);
				}
				return _lockingIndicator;
			}
			set
			{
				if (_lockingIndicator == value)
				{
					return;
				}
				_lockingIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gamesmartGunUITargetParameters) CR2WTypeManager.Create("gamesmartGunUITargetParameters", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get
			{
				if (_lockingAnimationProxy == null)
				{
					_lockingAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "lockingAnimationProxy", cr2w, this);
				}
				return _lockingAnimationProxy;
			}
			set
			{
				if (_lockingAnimationProxy == value)
				{
					return;
				}
				_lockingAnimationProxy = value;
				PropertySet(this);
			}
		}

		public Crosshair_Smart_Rifl_Bucket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
