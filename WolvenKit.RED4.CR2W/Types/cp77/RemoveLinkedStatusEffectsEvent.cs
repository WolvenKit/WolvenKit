using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveLinkedStatusEffectsEvent : redEvent
	{
		private CBool _ssAction;

		[Ordinal(0)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetProperty(ref _ssAction);
			set => SetProperty(ref _ssAction, value);
		}

		public RemoveLinkedStatusEffectsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
