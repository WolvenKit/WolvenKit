using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPreloadEffectEvent : redEvent
	{
		private CName _effectName;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		public entPreloadEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
