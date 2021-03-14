using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioScanningSettings : CVariable
	{
		private CName _scanningStartEvent;
		private CName _scanningStopEvent;
		private CName _scanningCompleteEvent;
		private CName _scanningAvailableEvent;

		[Ordinal(0)] 
		[RED("scanningStartEvent")] 
		public CName ScanningStartEvent
		{
			get
			{
				if (_scanningStartEvent == null)
				{
					_scanningStartEvent = (CName) CR2WTypeManager.Create("CName", "scanningStartEvent", cr2w, this);
				}
				return _scanningStartEvent;
			}
			set
			{
				if (_scanningStartEvent == value)
				{
					return;
				}
				_scanningStartEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scanningStopEvent")] 
		public CName ScanningStopEvent
		{
			get
			{
				if (_scanningStopEvent == null)
				{
					_scanningStopEvent = (CName) CR2WTypeManager.Create("CName", "scanningStopEvent", cr2w, this);
				}
				return _scanningStopEvent;
			}
			set
			{
				if (_scanningStopEvent == value)
				{
					return;
				}
				_scanningStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scanningCompleteEvent")] 
		public CName ScanningCompleteEvent
		{
			get
			{
				if (_scanningCompleteEvent == null)
				{
					_scanningCompleteEvent = (CName) CR2WTypeManager.Create("CName", "scanningCompleteEvent", cr2w, this);
				}
				return _scanningCompleteEvent;
			}
			set
			{
				if (_scanningCompleteEvent == value)
				{
					return;
				}
				_scanningCompleteEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scanningAvailableEvent")] 
		public CName ScanningAvailableEvent
		{
			get
			{
				if (_scanningAvailableEvent == null)
				{
					_scanningAvailableEvent = (CName) CR2WTypeManager.Create("CName", "scanningAvailableEvent", cr2w, this);
				}
				return _scanningAvailableEvent;
			}
			set
			{
				if (_scanningAvailableEvent == value)
				{
					return;
				}
				_scanningAvailableEvent = value;
				PropertySet(this);
			}
		}

		public audioScanningSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
