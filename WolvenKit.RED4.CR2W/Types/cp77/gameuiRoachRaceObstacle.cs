using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceObstacle : CVariable
	{
		private CFloat _interval;
		private CName _dynObjectType;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get
			{
				if (_interval == null)
				{
					_interval = (CFloat) CR2WTypeManager.Create("Float", "interval", cr2w, this);
				}
				return _interval;
			}
			set
			{
				if (_interval == value)
				{
					return;
				}
				_interval = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dynObjectType")] 
		public CName DynObjectType
		{
			get
			{
				if (_dynObjectType == null)
				{
					_dynObjectType = (CName) CR2WTypeManager.Create("CName", "dynObjectType", cr2w, this);
				}
				return _dynObjectType;
			}
			set
			{
				if (_dynObjectType == value)
				{
					return;
				}
				_dynObjectType = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRaceObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
