using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownPackage : IScriptable
	{
		private TweakDBID _actionID;
		private CArray<PSOwnerData> _addressees;
		private CFloat _initialCooldown;
		private CooldownStorageID _label;
		private CEnum<PackageStatus> _packageStatus;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addressees")] 
		public CArray<PSOwnerData> Addressees
		{
			get
			{
				if (_addressees == null)
				{
					_addressees = (CArray<PSOwnerData>) CR2WTypeManager.Create("array:PSOwnerData", "addressees", cr2w, this);
				}
				return _addressees;
			}
			set
			{
				if (_addressees == value)
				{
					return;
				}
				_addressees = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initialCooldown")] 
		public CFloat InitialCooldown
		{
			get
			{
				if (_initialCooldown == null)
				{
					_initialCooldown = (CFloat) CR2WTypeManager.Create("Float", "initialCooldown", cr2w, this);
				}
				return _initialCooldown;
			}
			set
			{
				if (_initialCooldown == value)
				{
					return;
				}
				_initialCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("label")] 
		public CooldownStorageID Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CooldownStorageID) CR2WTypeManager.Create("CooldownStorageID", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("packageStatus")] 
		public CEnum<PackageStatus> PackageStatus
		{
			get
			{
				if (_packageStatus == null)
				{
					_packageStatus = (CEnum<PackageStatus>) CR2WTypeManager.Create("PackageStatus", "packageStatus", cr2w, this);
				}
				return _packageStatus;
			}
			set
			{
				if (_packageStatus == value)
				{
					return;
				}
				_packageStatus = value;
				PropertySet(this);
			}
		}

		public CooldownPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
