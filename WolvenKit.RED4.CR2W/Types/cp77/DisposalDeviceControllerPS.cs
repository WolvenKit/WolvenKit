using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private DisposalDeviceSetup _disposalDeviceSetup;
		private DistractionSetup _distractionSetup;
		private DistractionSetup _explosionSetup;
		private CBool _isDistractionDisabled;
		private CBool _wasActivated;
		private CBool _wasLethalTakedownPerformed;
		private CBool _isPlayerCurrentlyPerformingDisposal;

		[Ordinal(103)] 
		[RED("DisposalDeviceSetup")] 
		public DisposalDeviceSetup DisposalDeviceSetup
		{
			get
			{
				if (_disposalDeviceSetup == null)
				{
					_disposalDeviceSetup = (DisposalDeviceSetup) CR2WTypeManager.Create("DisposalDeviceSetup", "DisposalDeviceSetup", cr2w, this);
				}
				return _disposalDeviceSetup;
			}
			set
			{
				if (_disposalDeviceSetup == value)
				{
					return;
				}
				_disposalDeviceSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("distractionSetup")] 
		public DistractionSetup DistractionSetup
		{
			get
			{
				if (_distractionSetup == null)
				{
					_distractionSetup = (DistractionSetup) CR2WTypeManager.Create("DistractionSetup", "distractionSetup", cr2w, this);
				}
				return _distractionSetup;
			}
			set
			{
				if (_distractionSetup == value)
				{
					return;
				}
				_distractionSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("explosionSetup")] 
		public DistractionSetup ExplosionSetup
		{
			get
			{
				if (_explosionSetup == null)
				{
					_explosionSetup = (DistractionSetup) CR2WTypeManager.Create("DistractionSetup", "explosionSetup", cr2w, this);
				}
				return _explosionSetup;
			}
			set
			{
				if (_explosionSetup == value)
				{
					return;
				}
				_explosionSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isDistractionDisabled")] 
		public CBool IsDistractionDisabled
		{
			get
			{
				if (_isDistractionDisabled == null)
				{
					_isDistractionDisabled = (CBool) CR2WTypeManager.Create("Bool", "isDistractionDisabled", cr2w, this);
				}
				return _isDistractionDisabled;
			}
			set
			{
				if (_isDistractionDisabled == value)
				{
					return;
				}
				_isDistractionDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("wasActivated")] 
		public CBool WasActivated
		{
			get
			{
				if (_wasActivated == null)
				{
					_wasActivated = (CBool) CR2WTypeManager.Create("Bool", "wasActivated", cr2w, this);
				}
				return _wasActivated;
			}
			set
			{
				if (_wasActivated == value)
				{
					return;
				}
				_wasActivated = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("wasLethalTakedownPerformed")] 
		public CBool WasLethalTakedownPerformed
		{
			get
			{
				if (_wasLethalTakedownPerformed == null)
				{
					_wasLethalTakedownPerformed = (CBool) CR2WTypeManager.Create("Bool", "wasLethalTakedownPerformed", cr2w, this);
				}
				return _wasLethalTakedownPerformed;
			}
			set
			{
				if (_wasLethalTakedownPerformed == value)
				{
					return;
				}
				_wasLethalTakedownPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("isPlayerCurrentlyPerformingDisposal")] 
		public CBool IsPlayerCurrentlyPerformingDisposal
		{
			get
			{
				if (_isPlayerCurrentlyPerformingDisposal == null)
				{
					_isPlayerCurrentlyPerformingDisposal = (CBool) CR2WTypeManager.Create("Bool", "isPlayerCurrentlyPerformingDisposal", cr2w, this);
				}
				return _isPlayerCurrentlyPerformingDisposal;
			}
			set
			{
				if (_isPlayerCurrentlyPerformingDisposal == value)
				{
					return;
				}
				_isPlayerCurrentlyPerformingDisposal = value;
				PropertySet(this);
			}
		}

		public DisposalDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
