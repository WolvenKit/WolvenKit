using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridItemTemplate : CVariable
	{
		private CUInt32 _sizeX;
		private CUInt32 _sizeY;
		private inkWidgetLibraryReference _widget;

		[Ordinal(0)] 
		[RED("sizeX")] 
		public CUInt32 SizeX
		{
			get => GetProperty(ref _sizeX);
			set => SetProperty(ref _sizeX, value);
		}

		[Ordinal(1)] 
		[RED("sizeY")] 
		public CUInt32 SizeY
		{
			get => GetProperty(ref _sizeY);
			set => SetProperty(ref _sizeY, value);
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public inkWidgetLibraryReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public inkGridItemTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
