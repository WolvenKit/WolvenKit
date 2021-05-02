using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuItemDimRequest : redEvent
	{
		private CBool _dim;

		[Ordinal(0)] 
		[RED("dim")] 
		public CBool Dim
		{
			get => GetProperty(ref _dim);
			set => SetProperty(ref _dim, value);
		}

		public MenuItemDimRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
