using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContextChangedEvent : redEvent
	{
		private CEnum<gameuiContext> _oldContext;
		private CEnum<gameuiContext> _newContext;

		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<gameuiContext> OldContext
		{
			get => GetProperty(ref _oldContext);
			set => SetProperty(ref _oldContext, value);
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<gameuiContext> NewContext
		{
			get => GetProperty(ref _newContext);
			set => SetProperty(ref _newContext, value);
		}

		public gameuiContextChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
