using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyNames : CVariable
	{
		private CName _parentAnimName;
		private CName _childAnimName;

		[Ordinal(0)] 
		[RED("ParentAnimName")] 
		public CName ParentAnimName
		{
			get
			{
				if (_parentAnimName == null)
				{
					_parentAnimName = (CName) CR2WTypeManager.Create("CName", "ParentAnimName", cr2w, this);
				}
				return _parentAnimName;
			}
			set
			{
				if (_parentAnimName == value)
				{
					return;
				}
				_parentAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ChildAnimName")] 
		public CName ChildAnimName
		{
			get
			{
				if (_childAnimName == null)
				{
					_childAnimName = (CName) CR2WTypeManager.Create("CName", "ChildAnimName", cr2w, this);
				}
				return _childAnimName;
			}
			set
			{
				if (_childAnimName == value)
				{
					return;
				}
				_childAnimName = value;
				PropertySet(this);
			}
		}

		public physicsRagdollBodyNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
