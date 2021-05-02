using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRollingListController : inkListController
	{
		private CInt32 _itemsToDisplay;
		private CFloat _convexity;
		private CFloat _verticalCompression;
		private CFloat _scrollTime;

		[Ordinal(6)] 
		[RED("itemsToDisplay")] 
		public CInt32 ItemsToDisplay
		{
			get => GetProperty(ref _itemsToDisplay);
			set => SetProperty(ref _itemsToDisplay, value);
		}

		[Ordinal(7)] 
		[RED("convexity")] 
		public CFloat Convexity
		{
			get => GetProperty(ref _convexity);
			set => SetProperty(ref _convexity, value);
		}

		[Ordinal(8)] 
		[RED("verticalCompression")] 
		public CFloat VerticalCompression
		{
			get => GetProperty(ref _verticalCompression);
			set => SetProperty(ref _verticalCompression, value);
		}

		[Ordinal(9)] 
		[RED("scrollTime")] 
		public CFloat ScrollTime
		{
			get => GetProperty(ref _scrollTime);
			set => SetProperty(ref _scrollTime, value);
		}

		public inkRollingListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
