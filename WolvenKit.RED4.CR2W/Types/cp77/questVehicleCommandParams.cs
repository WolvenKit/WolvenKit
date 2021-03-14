using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCommandParams : questAICommandParams
	{
		private CEnum<questVehicleCommandType> _type;
		private CHandle<questvehicleOnSplineParams> _additionalParamsOnSpline;
		private CHandle<questvehicleFollowParams> _additionalParamsFollow;
		private CHandle<questvehicleToNodeParams> _additionalParamsToNode;
		private CHandle<questvehicleRacingParams> _additionalParamsRacing;
		private CHandle<questvehicleJoinTrafficParams> _additionalParamsJoinTraffic;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questVehicleCommandType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questVehicleCommandType>) CR2WTypeManager.Create("questVehicleCommandType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additionalParamsOnSpline")] 
		public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline
		{
			get
			{
				if (_additionalParamsOnSpline == null)
				{
					_additionalParamsOnSpline = (CHandle<questvehicleOnSplineParams>) CR2WTypeManager.Create("handle:questvehicleOnSplineParams", "additionalParamsOnSpline", cr2w, this);
				}
				return _additionalParamsOnSpline;
			}
			set
			{
				if (_additionalParamsOnSpline == value)
				{
					return;
				}
				_additionalParamsOnSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("additionalParamsFollow")] 
		public CHandle<questvehicleFollowParams> AdditionalParamsFollow
		{
			get
			{
				if (_additionalParamsFollow == null)
				{
					_additionalParamsFollow = (CHandle<questvehicleFollowParams>) CR2WTypeManager.Create("handle:questvehicleFollowParams", "additionalParamsFollow", cr2w, this);
				}
				return _additionalParamsFollow;
			}
			set
			{
				if (_additionalParamsFollow == value)
				{
					return;
				}
				_additionalParamsFollow = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("additionalParamsToNode")] 
		public CHandle<questvehicleToNodeParams> AdditionalParamsToNode
		{
			get
			{
				if (_additionalParamsToNode == null)
				{
					_additionalParamsToNode = (CHandle<questvehicleToNodeParams>) CR2WTypeManager.Create("handle:questvehicleToNodeParams", "additionalParamsToNode", cr2w, this);
				}
				return _additionalParamsToNode;
			}
			set
			{
				if (_additionalParamsToNode == value)
				{
					return;
				}
				_additionalParamsToNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("additionalParamsRacing")] 
		public CHandle<questvehicleRacingParams> AdditionalParamsRacing
		{
			get
			{
				if (_additionalParamsRacing == null)
				{
					_additionalParamsRacing = (CHandle<questvehicleRacingParams>) CR2WTypeManager.Create("handle:questvehicleRacingParams", "additionalParamsRacing", cr2w, this);
				}
				return _additionalParamsRacing;
			}
			set
			{
				if (_additionalParamsRacing == value)
				{
					return;
				}
				_additionalParamsRacing = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("additionalParamsJoinTraffic")] 
		public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic
		{
			get
			{
				if (_additionalParamsJoinTraffic == null)
				{
					_additionalParamsJoinTraffic = (CHandle<questvehicleJoinTrafficParams>) CR2WTypeManager.Create("handle:questvehicleJoinTrafficParams", "additionalParamsJoinTraffic", cr2w, this);
				}
				return _additionalParamsJoinTraffic;
			}
			set
			{
				if (_additionalParamsJoinTraffic == value)
				{
					return;
				}
				_additionalParamsJoinTraffic = value;
				PropertySet(this);
			}
		}

		public questVehicleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
