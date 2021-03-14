using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimRequest : IScriptable
	{
		private CHandle<senseStimuliEvent> _stimuli;
		private CBool _hasExpirationDate;
		private CFloat _duration;
		private StimRequestID _requestID;

		[Ordinal(0)] 
		[RED("stimuli")] 
		public CHandle<senseStimuliEvent> Stimuli
		{
			get
			{
				if (_stimuli == null)
				{
					_stimuli = (CHandle<senseStimuliEvent>) CR2WTypeManager.Create("handle:senseStimuliEvent", "stimuli", cr2w, this);
				}
				return _stimuli;
			}
			set
			{
				if (_stimuli == value)
				{
					return;
				}
				_stimuli = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasExpirationDate")] 
		public CBool HasExpirationDate
		{
			get
			{
				if (_hasExpirationDate == null)
				{
					_hasExpirationDate = (CBool) CR2WTypeManager.Create("Bool", "hasExpirationDate", cr2w, this);
				}
				return _hasExpirationDate;
			}
			set
			{
				if (_hasExpirationDate == value)
				{
					return;
				}
				_hasExpirationDate = value;
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
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get
			{
				if (_requestID == null)
				{
					_requestID = (StimRequestID) CR2WTypeManager.Create("StimRequestID", "requestID", cr2w, this);
				}
				return _requestID;
			}
			set
			{
				if (_requestID == value)
				{
					return;
				}
				_requestID = value;
				PropertySet(this);
			}
		}

		public StimRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
