using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleInteriorParameterData : CVariable
	{
		private CEnum<audioESoundCurveType> _enterCurveType;
		private CFloat _enterCurveTime;
		private CFloat _enterDelayTime;
		private CEnum<audioESoundCurveType> _exitCurveType;
		private CFloat _exitCurveTime;
		private CFloat _exitDelayTime;

		[Ordinal(0)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get
			{
				if (_enterCurveType == null)
				{
					_enterCurveType = (CEnum<audioESoundCurveType>) CR2WTypeManager.Create("audioESoundCurveType", "enterCurveType", cr2w, this);
				}
				return _enterCurveType;
			}
			set
			{
				if (_enterCurveType == value)
				{
					return;
				}
				_enterCurveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get
			{
				if (_enterCurveTime == null)
				{
					_enterCurveTime = (CFloat) CR2WTypeManager.Create("Float", "enterCurveTime", cr2w, this);
				}
				return _enterCurveTime;
			}
			set
			{
				if (_enterCurveTime == value)
				{
					return;
				}
				_enterCurveTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enterDelayTime")] 
		public CFloat EnterDelayTime
		{
			get
			{
				if (_enterDelayTime == null)
				{
					_enterDelayTime = (CFloat) CR2WTypeManager.Create("Float", "enterDelayTime", cr2w, this);
				}
				return _enterDelayTime;
			}
			set
			{
				if (_enterDelayTime == value)
				{
					return;
				}
				_enterDelayTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get
			{
				if (_exitCurveType == null)
				{
					_exitCurveType = (CEnum<audioESoundCurveType>) CR2WTypeManager.Create("audioESoundCurveType", "exitCurveType", cr2w, this);
				}
				return _exitCurveType;
			}
			set
			{
				if (_exitCurveType == value)
				{
					return;
				}
				_exitCurveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get
			{
				if (_exitCurveTime == null)
				{
					_exitCurveTime = (CFloat) CR2WTypeManager.Create("Float", "exitCurveTime", cr2w, this);
				}
				return _exitCurveTime;
			}
			set
			{
				if (_exitCurveTime == value)
				{
					return;
				}
				_exitCurveTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exitDelayTime")] 
		public CFloat ExitDelayTime
		{
			get
			{
				if (_exitDelayTime == null)
				{
					_exitDelayTime = (CFloat) CR2WTypeManager.Create("Float", "exitDelayTime", cr2w, this);
				}
				return _exitDelayTime;
			}
			set
			{
				if (_exitDelayTime == value)
				{
					return;
				}
				_exitDelayTime = value;
				PropertySet(this);
			}
		}

		public audioVehicleInteriorParameterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
