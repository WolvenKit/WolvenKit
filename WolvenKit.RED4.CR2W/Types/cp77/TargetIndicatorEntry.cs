using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetIndicatorEntry : CVariable
	{
		private entEntityID _targetID;
		private wCHandle<inkWidget> _indicator;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("indicator")] 
		public wCHandle<inkWidget> Indicator
		{
			get
			{
				if (_indicator == null)
				{
					_indicator = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "indicator", cr2w, this);
				}
				return _indicator;
			}
			set
			{
				if (_indicator == value)
				{
					return;
				}
				_indicator = value;
				PropertySet(this);
			}
		}

		public TargetIndicatorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
