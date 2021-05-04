using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DummyEvent : redEvent
	{
		private CBool _disable;
		private CInt32 _ix;

		[Ordinal(0)] 
		[RED("disable")] 
		public CBool Disable
		{
			get => GetProperty(ref _disable);
			set => SetProperty(ref _disable, value);
		}

		[Ordinal(1)] 
		[RED("ix")] 
		public CInt32 Ix
		{
			get => GetProperty(ref _ix);
			set => SetProperty(ref _ix, value);
		}

		public DummyEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
