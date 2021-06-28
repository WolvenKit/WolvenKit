using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerCheatCode : CVariable
	{
		private CName _name;
		private CArray<CName> _keys;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("keys")] 
		public CArray<CName> Keys
		{
			get => GetProperty(ref _keys);
			set => SetProperty(ref _keys, value);
		}

		public gameuiSideScrollerCheatCode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
