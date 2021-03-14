using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalMeshComponent : entMeshComponent
	{
		private CName _visibilityAnimationParam;
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _useResourceSimulationType;
		private CBool _startInactive;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(22)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get
			{
				if (_visibilityAnimationParam == null)
				{
					_visibilityAnimationParam = (CName) CR2WTypeManager.Create("CName", "visibilityAnimationParam", cr2w, this);
				}
				return _visibilityAnimationParam;
			}
			set
			{
				if (_visibilityAnimationParam == value)
				{
					return;
				}
				_visibilityAnimationParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("useResourceSimulationType")] 
		public CBool UseResourceSimulationType
		{
			get
			{
				if (_useResourceSimulationType == null)
				{
					_useResourceSimulationType = (CBool) CR2WTypeManager.Create("Bool", "useResourceSimulationType", cr2w, this);
				}
				return _useResourceSimulationType;
			}
			set
			{
				if (_useResourceSimulationType == value)
				{
					return;
				}
				_useResourceSimulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get
			{
				if (_startInactive == null)
				{
					_startInactive = (CBool) CR2WTypeManager.Create("Bool", "startInactive", cr2w, this);
				}
				return _startInactive;
			}
			set
			{
				if (_startInactive == value)
				{
					return;
				}
				_startInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get
			{
				if (_filterDataSource == null)
				{
					_filterDataSource = (CEnum<physicsFilterDataSource>) CR2WTypeManager.Create("physicsFilterDataSource", "filterDataSource", cr2w, this);
				}
				return _filterDataSource;
			}
			set
			{
				if (_filterDataSource == value)
				{
					return;
				}
				_filterDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		public entPhysicalMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
