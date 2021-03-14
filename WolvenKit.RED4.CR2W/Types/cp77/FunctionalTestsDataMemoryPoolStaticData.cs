using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolStaticData : ISerializable
	{
		private CString _poolName;
		private CInt64 _budget;
		private CInt64 _childrenBudget;
		private CArray<CString> _children;
		private CString _parent;

		[Ordinal(0)] 
		[RED("poolName")] 
		public CString PoolName
		{
			get
			{
				if (_poolName == null)
				{
					_poolName = (CString) CR2WTypeManager.Create("String", "poolName", cr2w, this);
				}
				return _poolName;
			}
			set
			{
				if (_poolName == value)
				{
					return;
				}
				_poolName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("budget")] 
		public CInt64 Budget
		{
			get
			{
				if (_budget == null)
				{
					_budget = (CInt64) CR2WTypeManager.Create("Int64", "budget", cr2w, this);
				}
				return _budget;
			}
			set
			{
				if (_budget == value)
				{
					return;
				}
				_budget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("childrenBudget")] 
		public CInt64 ChildrenBudget
		{
			get
			{
				if (_childrenBudget == null)
				{
					_childrenBudget = (CInt64) CR2WTypeManager.Create("Int64", "childrenBudget", cr2w, this);
				}
				return _childrenBudget;
			}
			set
			{
				if (_childrenBudget == value)
				{
					return;
				}
				_childrenBudget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CString> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<CString>) CR2WTypeManager.Create("array:String", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parent")] 
		public CString Parent
		{
			get
			{
				if (_parent == null)
				{
					_parent = (CString) CR2WTypeManager.Create("String", "parent", cr2w, this);
				}
				return _parent;
			}
			set
			{
				if (_parent == value)
				{
					return;
				}
				_parent = value;
				PropertySet(this);
			}
		}

		public FunctionalTestsDataMemoryPoolStaticData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
