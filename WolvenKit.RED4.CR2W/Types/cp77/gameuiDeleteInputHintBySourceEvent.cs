using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDeleteInputHintBySourceEvent : redEvent
	{
		private CName _source;
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get
			{
				if (_targetHintContainer == null)
				{
					_targetHintContainer = (CName) CR2WTypeManager.Create("CName", "targetHintContainer", cr2w, this);
				}
				return _targetHintContainer;
			}
			set
			{
				if (_targetHintContainer == value)
				{
					return;
				}
				_targetHintContainer = value;
				PropertySet(this);
			}
		}

		public gameuiDeleteInputHintBySourceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
