using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionEvent : redEvent
	{
		private CName _actionID;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public ToggleCustomActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
