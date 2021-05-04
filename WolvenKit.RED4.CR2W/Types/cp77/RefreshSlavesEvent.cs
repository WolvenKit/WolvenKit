using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshSlavesEvent : redEvent
	{
		private CBool _onInitialize;

		[Ordinal(0)] 
		[RED("onInitialize")] 
		public CBool OnInitialize
		{
			get => GetProperty(ref _onInitialize);
			set => SetProperty(ref _onInitialize, value);
		}

		public RefreshSlavesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
