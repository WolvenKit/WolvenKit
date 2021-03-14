using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RealTimeUpdateRequest : gameScriptableSystemRequest
	{
		private CHandle<gameTickableEvent> _evt;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("evt")] 
		public CHandle<gameTickableEvent> Evt
		{
			get
			{
				if (_evt == null)
				{
					_evt = (CHandle<gameTickableEvent>) CR2WTypeManager.Create("handle:gameTickableEvent", "evt", cr2w, this);
				}
				return _evt;
			}
			set
			{
				if (_evt == value)
				{
					return;
				}
				_evt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public RealTimeUpdateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
