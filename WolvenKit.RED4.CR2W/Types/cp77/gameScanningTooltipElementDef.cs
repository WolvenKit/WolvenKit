using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningTooltipElementDef : CVariable
	{
		private TweakDBID _recordID;
		private CFloat _timePct;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timePct")] 
		public CFloat TimePct
		{
			get
			{
				if (_timePct == null)
				{
					_timePct = (CFloat) CR2WTypeManager.Create("Float", "timePct", cr2w, this);
				}
				return _timePct;
			}
			set
			{
				if (_timePct == value)
				{
					return;
				}
				_timePct = value;
				PropertySet(this);
			}
		}

		public gameScanningTooltipElementDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
