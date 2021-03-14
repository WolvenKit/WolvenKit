using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationJingleMetadata : CVariable
	{
		private CName _introJingleEvent;
		private CFloat _introDuration;
		private CName _middleJingleEvent;
		private CName _endJingleEvent;
		private CFloat _outroDuration;

		[Ordinal(0)] 
		[RED("introJingleEvent")] 
		public CName IntroJingleEvent
		{
			get
			{
				if (_introJingleEvent == null)
				{
					_introJingleEvent = (CName) CR2WTypeManager.Create("CName", "introJingleEvent", cr2w, this);
				}
				return _introJingleEvent;
			}
			set
			{
				if (_introJingleEvent == value)
				{
					return;
				}
				_introJingleEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("introDuration")] 
		public CFloat IntroDuration
		{
			get
			{
				if (_introDuration == null)
				{
					_introDuration = (CFloat) CR2WTypeManager.Create("Float", "introDuration", cr2w, this);
				}
				return _introDuration;
			}
			set
			{
				if (_introDuration == value)
				{
					return;
				}
				_introDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("middleJingleEvent")] 
		public CName MiddleJingleEvent
		{
			get
			{
				if (_middleJingleEvent == null)
				{
					_middleJingleEvent = (CName) CR2WTypeManager.Create("CName", "middleJingleEvent", cr2w, this);
				}
				return _middleJingleEvent;
			}
			set
			{
				if (_middleJingleEvent == value)
				{
					return;
				}
				_middleJingleEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endJingleEvent")] 
		public CName EndJingleEvent
		{
			get
			{
				if (_endJingleEvent == null)
				{
					_endJingleEvent = (CName) CR2WTypeManager.Create("CName", "endJingleEvent", cr2w, this);
				}
				return _endJingleEvent;
			}
			set
			{
				if (_endJingleEvent == value)
				{
					return;
				}
				_endJingleEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get
			{
				if (_outroDuration == null)
				{
					_outroDuration = (CFloat) CR2WTypeManager.Create("Float", "outroDuration", cr2w, this);
				}
				return _outroDuration;
			}
			set
			{
				if (_outroDuration == value)
				{
					return;
				}
				_outroDuration = value;
				PropertySet(this);
			}
		}

		public audioRadioStationJingleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
