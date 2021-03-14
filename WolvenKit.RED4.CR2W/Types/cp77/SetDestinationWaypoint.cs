using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDestinationWaypoint : AIActionHelperTask
	{
		private CEnum<EAITargetType> _refTargetType;
		private CBool _findClosest;
		private CName _waypointsName;
		private CArray<Vector4> _destinations;
		private CArray<Vector4> _finalDestinations;

		[Ordinal(5)] 
		[RED("refTargetType")] 
		public CEnum<EAITargetType> RefTargetType
		{
			get
			{
				if (_refTargetType == null)
				{
					_refTargetType = (CEnum<EAITargetType>) CR2WTypeManager.Create("EAITargetType", "refTargetType", cr2w, this);
				}
				return _refTargetType;
			}
			set
			{
				if (_refTargetType == value)
				{
					return;
				}
				_refTargetType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("findClosest")] 
		public CBool FindClosest
		{
			get
			{
				if (_findClosest == null)
				{
					_findClosest = (CBool) CR2WTypeManager.Create("Bool", "findClosest", cr2w, this);
				}
				return _findClosest;
			}
			set
			{
				if (_findClosest == value)
				{
					return;
				}
				_findClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("waypointsName")] 
		public CName WaypointsName
		{
			get
			{
				if (_waypointsName == null)
				{
					_waypointsName = (CName) CR2WTypeManager.Create("CName", "waypointsName", cr2w, this);
				}
				return _waypointsName;
			}
			set
			{
				if (_waypointsName == value)
				{
					return;
				}
				_waypointsName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("destinations")] 
		public CArray<Vector4> Destinations
		{
			get
			{
				if (_destinations == null)
				{
					_destinations = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "destinations", cr2w, this);
				}
				return _destinations;
			}
			set
			{
				if (_destinations == value)
				{
					return;
				}
				_destinations = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("finalDestinations")] 
		public CArray<Vector4> FinalDestinations
		{
			get
			{
				if (_finalDestinations == null)
				{
					_finalDestinations = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "finalDestinations", cr2w, this);
				}
				return _finalDestinations;
			}
			set
			{
				if (_finalDestinations == value)
				{
					return;
				}
				_finalDestinations = value;
				PropertySet(this);
			}
		}

		public SetDestinationWaypoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
