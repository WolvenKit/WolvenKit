using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpMeatBag : gameObject
	{
		private CFloat _rotationLerpFactor;
		private CName _kinematicBodyBoneName;
		private CName _bagBodyBoneName;
		private CName _physicalComponentName;
		private CName _bagHitComponentName;
		private CName _bagDestroyComponentName;
		private CName _destructionEffectName;
		private CName _jiggleEffectName;

		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get
			{
				if (_rotationLerpFactor == null)
				{
					_rotationLerpFactor = (CFloat) CR2WTypeManager.Create("Float", "rotationLerpFactor", cr2w, this);
				}
				return _rotationLerpFactor;
			}
			set
			{
				if (_rotationLerpFactor == value)
				{
					return;
				}
				_rotationLerpFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("kinematicBodyBoneName")] 
		public CName KinematicBodyBoneName
		{
			get
			{
				if (_kinematicBodyBoneName == null)
				{
					_kinematicBodyBoneName = (CName) CR2WTypeManager.Create("CName", "kinematicBodyBoneName", cr2w, this);
				}
				return _kinematicBodyBoneName;
			}
			set
			{
				if (_kinematicBodyBoneName == value)
				{
					return;
				}
				_kinematicBodyBoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("bagBodyBoneName")] 
		public CName BagBodyBoneName
		{
			get
			{
				if (_bagBodyBoneName == null)
				{
					_bagBodyBoneName = (CName) CR2WTypeManager.Create("CName", "bagBodyBoneName", cr2w, this);
				}
				return _bagBodyBoneName;
			}
			set
			{
				if (_bagBodyBoneName == value)
				{
					return;
				}
				_bagBodyBoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("physicalComponentName")] 
		public CName PhysicalComponentName
		{
			get
			{
				if (_physicalComponentName == null)
				{
					_physicalComponentName = (CName) CR2WTypeManager.Create("CName", "physicalComponentName", cr2w, this);
				}
				return _physicalComponentName;
			}
			set
			{
				if (_physicalComponentName == value)
				{
					return;
				}
				_physicalComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("bagHitComponentName")] 
		public CName BagHitComponentName
		{
			get
			{
				if (_bagHitComponentName == null)
				{
					_bagHitComponentName = (CName) CR2WTypeManager.Create("CName", "bagHitComponentName", cr2w, this);
				}
				return _bagHitComponentName;
			}
			set
			{
				if (_bagHitComponentName == value)
				{
					return;
				}
				_bagHitComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("bagDestroyComponentName")] 
		public CName BagDestroyComponentName
		{
			get
			{
				if (_bagDestroyComponentName == null)
				{
					_bagDestroyComponentName = (CName) CR2WTypeManager.Create("CName", "bagDestroyComponentName", cr2w, this);
				}
				return _bagDestroyComponentName;
			}
			set
			{
				if (_bagDestroyComponentName == value)
				{
					return;
				}
				_bagDestroyComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("destructionEffectName")] 
		public CName DestructionEffectName
		{
			get
			{
				if (_destructionEffectName == null)
				{
					_destructionEffectName = (CName) CR2WTypeManager.Create("CName", "destructionEffectName", cr2w, this);
				}
				return _destructionEffectName;
			}
			set
			{
				if (_destructionEffectName == value)
				{
					return;
				}
				_destructionEffectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("jiggleEffectName")] 
		public CName JiggleEffectName
		{
			get
			{
				if (_jiggleEffectName == null)
				{
					_jiggleEffectName = (CName) CR2WTypeManager.Create("CName", "jiggleEffectName", cr2w, this);
				}
				return _jiggleEffectName;
			}
			set
			{
				if (_jiggleEffectName == value)
				{
					return;
				}
				_jiggleEffectName = value;
				PropertySet(this);
			}
		}

		public cpMeatBag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
