using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintInitializedEvent : redEvent
	{
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetProperty(ref _targetHintContainer);
			set => SetProperty(ref _targetHintContainer, value);
		}

		public gameuiInputHintInitializedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
