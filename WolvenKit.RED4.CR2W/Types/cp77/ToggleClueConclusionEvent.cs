using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleClueConclusionEvent : redEvent
	{
		private CBool _toggleConclusion;
		private CInt32 _clueID;
		private CBool _updatePS;

		[Ordinal(0)] 
		[RED("toggleConclusion")] 
		public CBool ToggleConclusion
		{
			get
			{
				if (_toggleConclusion == null)
				{
					_toggleConclusion = (CBool) CR2WTypeManager.Create("Bool", "toggleConclusion", cr2w, this);
				}
				return _toggleConclusion;
			}
			set
			{
				if (_toggleConclusion == value)
				{
					return;
				}
				_toggleConclusion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("clueID")] 
		public CInt32 ClueID
		{
			get
			{
				if (_clueID == null)
				{
					_clueID = (CInt32) CR2WTypeManager.Create("Int32", "clueID", cr2w, this);
				}
				return _clueID;
			}
			set
			{
				if (_clueID == value)
				{
					return;
				}
				_clueID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get
			{
				if (_updatePS == null)
				{
					_updatePS = (CBool) CR2WTypeManager.Create("Bool", "updatePS", cr2w, this);
				}
				return _updatePS;
			}
			set
			{
				if (_updatePS == value)
				{
					return;
				}
				_updatePS = value;
				PropertySet(this);
			}
		}

		public ToggleClueConclusionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
