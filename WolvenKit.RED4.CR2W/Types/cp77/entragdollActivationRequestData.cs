using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entragdollActivationRequestData : CVariable
	{
		private CEnum<entragdollActivationRequestType> _type;
		private CFloat _activationNoGroundThreshold;
		private CBool _activateOnCollision;
		private CBool _applyPowerPose;
		private CBool _applyMomentum;
		private CName _filterDataOverride;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entragdollActivationRequestType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<entragdollActivationRequestType>) CR2WTypeManager.Create("entragdollActivationRequestType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activationNoGroundThreshold")] 
		public CFloat ActivationNoGroundThreshold
		{
			get
			{
				if (_activationNoGroundThreshold == null)
				{
					_activationNoGroundThreshold = (CFloat) CR2WTypeManager.Create("Float", "activationNoGroundThreshold", cr2w, this);
				}
				return _activationNoGroundThreshold;
			}
			set
			{
				if (_activationNoGroundThreshold == value)
				{
					return;
				}
				_activationNoGroundThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activateOnCollision")] 
		public CBool ActivateOnCollision
		{
			get
			{
				if (_activateOnCollision == null)
				{
					_activateOnCollision = (CBool) CR2WTypeManager.Create("Bool", "activateOnCollision", cr2w, this);
				}
				return _activateOnCollision;
			}
			set
			{
				if (_activateOnCollision == value)
				{
					return;
				}
				_activateOnCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("applyPowerPose")] 
		public CBool ApplyPowerPose
		{
			get
			{
				if (_applyPowerPose == null)
				{
					_applyPowerPose = (CBool) CR2WTypeManager.Create("Bool", "applyPowerPose", cr2w, this);
				}
				return _applyPowerPose;
			}
			set
			{
				if (_applyPowerPose == value)
				{
					return;
				}
				_applyPowerPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("applyMomentum")] 
		public CBool ApplyMomentum
		{
			get
			{
				if (_applyMomentum == null)
				{
					_applyMomentum = (CBool) CR2WTypeManager.Create("Bool", "applyMomentum", cr2w, this);
				}
				return _applyMomentum;
			}
			set
			{
				if (_applyMomentum == value)
				{
					return;
				}
				_applyMomentum = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("filterDataOverride")] 
		public CName FilterDataOverride
		{
			get
			{
				if (_filterDataOverride == null)
				{
					_filterDataOverride = (CName) CR2WTypeManager.Create("CName", "filterDataOverride", cr2w, this);
				}
				return _filterDataOverride;
			}
			set
			{
				if (_filterDataOverride == value)
				{
					return;
				}
				_filterDataOverride = value;
				PropertySet(this);
			}
		}

		public entragdollActivationRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
