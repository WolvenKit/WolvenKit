using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestTakeControl : gameScriptableSystemRequest
	{
		private entEntityID _requestSource;
		private CHandle<ToggleTakeOverControl> _originalEvent;

		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get
			{
				if (_requestSource == null)
				{
					_requestSource = (entEntityID) CR2WTypeManager.Create("entEntityID", "requestSource", cr2w, this);
				}
				return _requestSource;
			}
			set
			{
				if (_requestSource == value)
				{
					return;
				}
				_requestSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("originalEvent")] 
		public CHandle<ToggleTakeOverControl> OriginalEvent
		{
			get
			{
				if (_originalEvent == null)
				{
					_originalEvent = (CHandle<ToggleTakeOverControl>) CR2WTypeManager.Create("handle:ToggleTakeOverControl", "originalEvent", cr2w, this);
				}
				return _originalEvent;
			}
			set
			{
				if (_originalEvent == value)
				{
					return;
				}
				_originalEvent = value;
				PropertySet(this);
			}
		}

		public RequestTakeControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
