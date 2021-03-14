using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleFocusClueEvent : redEvent
	{
		private CInt32 _clueIndex;
		private CBool _isEnabled;
		private CEnum<EFocusClueInvestigationState> _investigationState;
		private CBool _updatePS;

		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get
			{
				if (_clueIndex == null)
				{
					_clueIndex = (CInt32) CR2WTypeManager.Create("Int32", "clueIndex", cr2w, this);
				}
				return _clueIndex;
			}
			set
			{
				if (_clueIndex == value)
				{
					return;
				}
				_clueIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("investigationState")] 
		public CEnum<EFocusClueInvestigationState> InvestigationState
		{
			get
			{
				if (_investigationState == null)
				{
					_investigationState = (CEnum<EFocusClueInvestigationState>) CR2WTypeManager.Create("EFocusClueInvestigationState", "investigationState", cr2w, this);
				}
				return _investigationState;
			}
			set
			{
				if (_investigationState == value)
				{
					return;
				}
				_investigationState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public ToggleFocusClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
