using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWeapon_NodeType : questIItemManagerNodeType
	{
		private CEnum<questWeaponUsageType> _usageType;
		private CHandle<questUniversalRef> _objectRef;
		private CName _overrideShootEffect;

		[Ordinal(0)] 
		[RED("usageType")] 
		public CEnum<questWeaponUsageType> UsageType
		{
			get
			{
				if (_usageType == null)
				{
					_usageType = (CEnum<questWeaponUsageType>) CR2WTypeManager.Create("questWeaponUsageType", "usageType", cr2w, this);
				}
				return _usageType;
			}
			set
			{
				if (_usageType == value)
				{
					return;
				}
				_usageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrideShootEffect")] 
		public CName OverrideShootEffect
		{
			get
			{
				if (_overrideShootEffect == null)
				{
					_overrideShootEffect = (CName) CR2WTypeManager.Create("CName", "overrideShootEffect", cr2w, this);
				}
				return _overrideShootEffect;
			}
			set
			{
				if (_overrideShootEffect == value)
				{
					return;
				}
				_overrideShootEffect = value;
				PropertySet(this);
			}
		}

		public questUseWeapon_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
