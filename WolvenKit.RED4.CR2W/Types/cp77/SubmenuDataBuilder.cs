using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubmenuDataBuilder : IScriptable
	{
		private CHandle<MenuDataBuilder> _menuBuilder;
		private CInt32 _menuDataIndex;

		[Ordinal(0)] 
		[RED("menuBuilder")] 
		public CHandle<MenuDataBuilder> MenuBuilder
		{
			get => GetProperty(ref _menuBuilder);
			set => SetProperty(ref _menuBuilder, value);
		}

		[Ordinal(1)] 
		[RED("menuDataIndex")] 
		public CInt32 MenuDataIndex
		{
			get => GetProperty(ref _menuDataIndex);
			set => SetProperty(ref _menuDataIndex, value);
		}

		public SubmenuDataBuilder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
