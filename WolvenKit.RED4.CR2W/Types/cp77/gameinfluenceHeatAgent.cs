using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		private CFloat _timeToNextUpdate;
		private CFloat _heatRadius;
		private CFloat _heatValue;

		[Ordinal(0)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get
			{
				if (_timeToNextUpdate == null)
				{
					_timeToNextUpdate = (CFloat) CR2WTypeManager.Create("Float", "timeToNextUpdate", cr2w, this);
				}
				return _timeToNextUpdate;
			}
			set
			{
				if (_timeToNextUpdate == value)
				{
					return;
				}
				_timeToNextUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("heatRadius")] 
		public CFloat HeatRadius
		{
			get
			{
				if (_heatRadius == null)
				{
					_heatRadius = (CFloat) CR2WTypeManager.Create("Float", "heatRadius", cr2w, this);
				}
				return _heatRadius;
			}
			set
			{
				if (_heatRadius == value)
				{
					return;
				}
				_heatRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("heatValue")] 
		public CFloat HeatValue
		{
			get
			{
				if (_heatValue == null)
				{
					_heatValue = (CFloat) CR2WTypeManager.Create("Float", "heatValue", cr2w, this);
				}
				return _heatValue;
			}
			set
			{
				if (_heatValue == value)
				{
					return;
				}
				_heatValue = value;
				PropertySet(this);
			}
		}

		public gameinfluenceHeatAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
