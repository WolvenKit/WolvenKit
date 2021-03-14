using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetSearchQuery : CVariable
	{
		private CEnum<gameTargetingSet> _testedSet;
		private gameTargetSearchFilter _searchFilter;
		private CBool _includeSecondaryTargets;
		private CBool _ignoreInstigator;
		private CFloat _maxDistance;
		private entEntityID _queryTarget;

		[Ordinal(0)] 
		[RED("testedSet")] 
		public CEnum<gameTargetingSet> TestedSet
		{
			get
			{
				if (_testedSet == null)
				{
					_testedSet = (CEnum<gameTargetingSet>) CR2WTypeManager.Create("gameTargetingSet", "testedSet", cr2w, this);
				}
				return _testedSet;
			}
			set
			{
				if (_testedSet == value)
				{
					return;
				}
				_testedSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("searchFilter")] 
		public gameTargetSearchFilter SearchFilter
		{
			get
			{
				if (_searchFilter == null)
				{
					_searchFilter = (gameTargetSearchFilter) CR2WTypeManager.Create("gameTargetSearchFilter", "searchFilter", cr2w, this);
				}
				return _searchFilter;
			}
			set
			{
				if (_searchFilter == value)
				{
					return;
				}
				_searchFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("includeSecondaryTargets")] 
		public CBool IncludeSecondaryTargets
		{
			get
			{
				if (_includeSecondaryTargets == null)
				{
					_includeSecondaryTargets = (CBool) CR2WTypeManager.Create("Bool", "includeSecondaryTargets", cr2w, this);
				}
				return _includeSecondaryTargets;
			}
			set
			{
				if (_includeSecondaryTargets == value)
				{
					return;
				}
				_includeSecondaryTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreInstigator")] 
		public CBool IgnoreInstigator
		{
			get
			{
				if (_ignoreInstigator == null)
				{
					_ignoreInstigator = (CBool) CR2WTypeManager.Create("Bool", "ignoreInstigator", cr2w, this);
				}
				return _ignoreInstigator;
			}
			set
			{
				if (_ignoreInstigator == value)
				{
					return;
				}
				_ignoreInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("queryTarget")] 
		public entEntityID QueryTarget
		{
			get
			{
				if (_queryTarget == null)
				{
					_queryTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "queryTarget", cr2w, this);
				}
				return _queryTarget;
			}
			set
			{
				if (_queryTarget == value)
				{
					return;
				}
				_queryTarget = value;
				PropertySet(this);
			}
		}

		public gameTargetSearchQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
