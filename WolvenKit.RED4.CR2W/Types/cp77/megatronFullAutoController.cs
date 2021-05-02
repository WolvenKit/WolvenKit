using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronFullAutoController : AmmoLogicController
	{
		private wCHandle<inkTextWidget> _ammoCountText;
		private wCHandle<inkImageWidget> _ammoBar;

		[Ordinal(3)] 
		[RED("ammoCountText")] 
		public wCHandle<inkTextWidget> AmmoCountText
		{
			get => GetProperty(ref _ammoCountText);
			set => SetProperty(ref _ammoCountText, value);
		}

		[Ordinal(4)] 
		[RED("ammoBar")] 
		public wCHandle<inkImageWidget> AmmoBar
		{
			get => GetProperty(ref _ammoBar);
			set => SetProperty(ref _ammoBar, value);
		}

		public megatronFullAutoController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
