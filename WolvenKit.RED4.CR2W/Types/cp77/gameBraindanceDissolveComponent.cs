using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBraindanceDissolveComponent : entIComponent
	{
		private CFloat _dissolveRadius;

		[Ordinal(3)] 
		[RED("dissolveRadius")] 
		public CFloat DissolveRadius
		{
			get => GetProperty(ref _dissolveRadius);
			set => SetProperty(ref _dissolveRadius, value);
		}

		public gameBraindanceDissolveComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
