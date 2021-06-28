using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamebbID : CVariable
	{
		private CName _g;

		[Ordinal(0)] 
		[RED("g")] 
		public CName G
		{
			get => GetProperty(ref _g);
			set => SetProperty(ref _g, value);
		}

		public gamebbID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
