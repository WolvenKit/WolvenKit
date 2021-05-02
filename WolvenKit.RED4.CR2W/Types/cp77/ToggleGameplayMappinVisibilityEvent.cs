using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleGameplayMappinVisibilityEvent : redEvent
	{
		private CBool _isHidden;

		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		public ToggleGameplayMappinVisibilityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
