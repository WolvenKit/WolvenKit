using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectRef : CVariable
	{
		private rRef<gameEffectSet> _set;
		private CName _tag;

		[Ordinal(0)] 
		[RED("set")] 
		public rRef<gameEffectSet> Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		public gameEffectRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
