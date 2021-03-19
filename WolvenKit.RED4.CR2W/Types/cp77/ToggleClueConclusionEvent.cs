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
			get => GetProperty(ref _toggleConclusion);
			set => SetProperty(ref _toggleConclusion, value);
		}

		[Ordinal(1)] 
		[RED("clueID")] 
		public CInt32 ClueID
		{
			get => GetProperty(ref _clueID);
			set => SetProperty(ref _clueID, value);
		}

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetProperty(ref _updatePS);
			set => SetProperty(ref _updatePS, value);
		}

		public ToggleClueConclusionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
