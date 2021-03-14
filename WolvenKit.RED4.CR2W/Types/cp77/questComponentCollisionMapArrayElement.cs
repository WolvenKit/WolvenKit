using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questComponentCollisionMapArrayElement : CVariable
	{
		private CName _componentNameKey;
		private CBool _enableCollision;
		private CBool _enableQueries;

		[Ordinal(0)] 
		[RED("componentNameKey")] 
		public CName ComponentNameKey
		{
			get
			{
				if (_componentNameKey == null)
				{
					_componentNameKey = (CName) CR2WTypeManager.Create("CName", "componentNameKey", cr2w, this);
				}
				return _componentNameKey;
			}
			set
			{
				if (_componentNameKey == value)
				{
					return;
				}
				_componentNameKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get
			{
				if (_enableCollision == null)
				{
					_enableCollision = (CBool) CR2WTypeManager.Create("Bool", "enableCollision", cr2w, this);
				}
				return _enableCollision;
			}
			set
			{
				if (_enableCollision == value)
				{
					return;
				}
				_enableCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get
			{
				if (_enableQueries == null)
				{
					_enableQueries = (CBool) CR2WTypeManager.Create("Bool", "enableQueries", cr2w, this);
				}
				return _enableQueries;
			}
			set
			{
				if (_enableQueries == value)
				{
					return;
				}
				_enableQueries = value;
				PropertySet(this);
			}
		}

		public questComponentCollisionMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
