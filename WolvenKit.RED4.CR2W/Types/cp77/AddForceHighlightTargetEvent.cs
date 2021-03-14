using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddForceHighlightTargetEvent : redEvent
	{
		private entEntityID _targetID;
		private CName _effecName;

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
		[RED("effecName")] 
		public CName EffecName
		{
			get
			{
				if (_effecName == null)
				{
					_effecName = (CName) CR2WTypeManager.Create("CName", "effecName", cr2w, this);
				}
				return _effecName;
			}
			set
			{
				if (_effecName == value)
				{
					return;
				}
				_effecName = value;
				PropertySet(this);
			}
		}

		public AddForceHighlightTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
