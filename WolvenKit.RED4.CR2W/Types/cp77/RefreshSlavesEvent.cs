using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshSlavesEvent : ProcessDevicesEvent
	{
		private CBool _onInitialize;
		private CBool _force;

		[Ordinal(1)] 
		[RED("onInitialize")] 
		public CBool OnInitialize
		{
			get => GetProperty(ref _onInitialize);
			set => SetProperty(ref _onInitialize, value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		public RefreshSlavesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
