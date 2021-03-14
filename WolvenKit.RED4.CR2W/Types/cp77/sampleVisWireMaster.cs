using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMaster : gameObject
	{
		private CArray<NodeRef> _dependableEntities;
		private CBool _inFocus;
		private CBool _found;
		private CBool _lookedAt;

		[Ordinal(40)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get
			{
				if (_dependableEntities == null)
				{
					_dependableEntities = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "dependableEntities", cr2w, this);
				}
				return _dependableEntities;
			}
			set
			{
				if (_dependableEntities == value)
				{
					return;
				}
				_dependableEntities = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("inFocus")] 
		public CBool InFocus
		{
			get
			{
				if (_inFocus == null)
				{
					_inFocus = (CBool) CR2WTypeManager.Create("Bool", "inFocus", cr2w, this);
				}
				return _inFocus;
			}
			set
			{
				if (_inFocus == value)
				{
					return;
				}
				_inFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("found")] 
		public CBool Found
		{
			get
			{
				if (_found == null)
				{
					_found = (CBool) CR2WTypeManager.Create("Bool", "found", cr2w, this);
				}
				return _found;
			}
			set
			{
				if (_found == value)
				{
					return;
				}
				_found = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("lookedAt")] 
		public CBool LookedAt
		{
			get
			{
				if (_lookedAt == null)
				{
					_lookedAt = (CBool) CR2WTypeManager.Create("Bool", "lookedAt", cr2w, this);
				}
				return _lookedAt;
			}
			set
			{
				if (_lookedAt == value)
				{
					return;
				}
				_lookedAt = value;
				PropertySet(this);
			}
		}

		public sampleVisWireMaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
