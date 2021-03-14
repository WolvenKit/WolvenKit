using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private gameTargetSearchQuery _searchQuery;
		private EulerAngles _searchAngles;
		private CUInt32 _maxTargets;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("searchQuery")] 
		public gameTargetSearchQuery SearchQuery
		{
			get
			{
				if (_searchQuery == null)
				{
					_searchQuery = (gameTargetSearchQuery) CR2WTypeManager.Create("gameTargetSearchQuery", "searchQuery", cr2w, this);
				}
				return _searchQuery;
			}
			set
			{
				if (_searchQuery == value)
				{
					return;
				}
				_searchQuery = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("searchAngles")] 
		public EulerAngles SearchAngles
		{
			get
			{
				if (_searchAngles == null)
				{
					_searchAngles = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "searchAngles", cr2w, this);
				}
				return _searchAngles;
			}
			set
			{
				if (_searchAngles == value)
				{
					return;
				}
				_searchAngles = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxTargets")] 
		public CUInt32 MaxTargets
		{
			get
			{
				if (_maxTargets == null)
				{
					_maxTargets = (CUInt32) CR2WTypeManager.Create("Uint32", "maxTargets", cr2w, this);
				}
				return _maxTargets;
			}
			set
			{
				if (_maxTargets == value)
				{
					return;
				}
				_maxTargets = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectProvider_TargetingObjectsInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
