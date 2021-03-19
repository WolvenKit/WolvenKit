using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimChangeStateEvent : inkanimEvent
	{
		private CName _state;

		[Ordinal(1)] 
		[RED("state")] 
		public CName State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public inkanimChangeStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
