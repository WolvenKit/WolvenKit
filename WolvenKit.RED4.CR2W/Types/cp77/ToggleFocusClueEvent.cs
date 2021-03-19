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
			get => GetProperty(ref _clueIndex);
			set => SetProperty(ref _clueIndex, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(2)] 
		[RED("investigationState")] 
		public CEnum<EFocusClueInvestigationState> InvestigationState
		{
			get => GetProperty(ref _investigationState);
			set => SetProperty(ref _investigationState, value);
		}

		[Ordinal(3)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetProperty(ref _updatePS);
			set => SetProperty(ref _updatePS, value);
		}

		public ToggleFocusClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
