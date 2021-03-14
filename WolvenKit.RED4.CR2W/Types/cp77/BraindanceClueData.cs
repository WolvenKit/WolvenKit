using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceClueData : CVariable
	{
		private CName _id;
		private CFloat _startTime;
		private CFloat _duration;
		private CEnum<ClueState> _state;
		private CEnum<gameuiEBraindanceLayer> _layer;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CName) CR2WTypeManager.Create("CName", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<ClueState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ClueState>) CR2WTypeManager.Create("ClueState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CEnum<gameuiEBraindanceLayer>) CR2WTypeManager.Create("gameuiEBraindanceLayer", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		public BraindanceClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
