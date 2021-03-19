using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entShadowMeshChangeEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _requestedState;

		[Ordinal(0)] 
		[RED("requestedState")] 
		public CEnum<entAppearanceStatus> RequestedState
		{
			get => GetProperty(ref _requestedState);
			set => SetProperty(ref _requestedState, value);
		}

		public entShadowMeshChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
