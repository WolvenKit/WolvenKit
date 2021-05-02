using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		private TweakDBID _iconReference;

		[Ordinal(1)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get => GetProperty(ref _iconReference);
			set => SetProperty(ref _iconReference, value);
		}

		public gameuiStaticIconLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
