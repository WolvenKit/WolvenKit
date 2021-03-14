using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectInfo : CVariable
	{
		private CArray<CName> _placementTags;
		private CArray<CName> _componentNames;
		private CArray<Vector3> _relativePositions;
		private CArray<Quaternion> _relativeRotations;
		private CArray<worldCompiledEffectPlacementInfo> _placementInfos;
		private CArray<worldCompiledEffectEventInfo> _eventsSortedByRUID;

		[Ordinal(0)] 
		[RED("placementTags")] 
		public CArray<CName> PlacementTags
		{
			get
			{
				if (_placementTags == null)
				{
					_placementTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "placementTags", cr2w, this);
				}
				return _placementTags;
			}
			set
			{
				if (_placementTags == value)
				{
					return;
				}
				_placementTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get
			{
				if (_componentNames == null)
				{
					_componentNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "componentNames", cr2w, this);
				}
				return _componentNames;
			}
			set
			{
				if (_componentNames == value)
				{
					return;
				}
				_componentNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("relativePositions")] 
		public CArray<Vector3> RelativePositions
		{
			get
			{
				if (_relativePositions == null)
				{
					_relativePositions = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "relativePositions", cr2w, this);
				}
				return _relativePositions;
			}
			set
			{
				if (_relativePositions == value)
				{
					return;
				}
				_relativePositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("relativeRotations")] 
		public CArray<Quaternion> RelativeRotations
		{
			get
			{
				if (_relativeRotations == null)
				{
					_relativeRotations = (CArray<Quaternion>) CR2WTypeManager.Create("array:Quaternion", "relativeRotations", cr2w, this);
				}
				return _relativeRotations;
			}
			set
			{
				if (_relativeRotations == value)
				{
					return;
				}
				_relativeRotations = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("placementInfos")] 
		public CArray<worldCompiledEffectPlacementInfo> PlacementInfos
		{
			get
			{
				if (_placementInfos == null)
				{
					_placementInfos = (CArray<worldCompiledEffectPlacementInfo>) CR2WTypeManager.Create("array:worldCompiledEffectPlacementInfo", "placementInfos", cr2w, this);
				}
				return _placementInfos;
			}
			set
			{
				if (_placementInfos == value)
				{
					return;
				}
				_placementInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("eventsSortedByRUID")] 
		public CArray<worldCompiledEffectEventInfo> EventsSortedByRUID
		{
			get
			{
				if (_eventsSortedByRUID == null)
				{
					_eventsSortedByRUID = (CArray<worldCompiledEffectEventInfo>) CR2WTypeManager.Create("array:worldCompiledEffectEventInfo", "eventsSortedByRUID", cr2w, this);
				}
				return _eventsSortedByRUID;
			}
			set
			{
				if (_eventsSortedByRUID == value)
				{
					return;
				}
				_eventsSortedByRUID = value;
				PropertySet(this);
			}
		}

		public worldCompiledEffectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
