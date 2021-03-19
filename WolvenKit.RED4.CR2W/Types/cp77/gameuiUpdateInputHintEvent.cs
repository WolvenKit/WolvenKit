using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUpdateInputHintEvent : redEvent
	{
		private gameuiInputHintData _data;
		private CBool _show;
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("data")] 
		public gameuiInputHintData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetProperty(ref _targetHintContainer);
			set => SetProperty(ref _targetHintContainer, value);
		}

		public gameuiUpdateInputHintEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
