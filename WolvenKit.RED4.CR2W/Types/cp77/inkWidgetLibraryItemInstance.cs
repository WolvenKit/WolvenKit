using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemInstance : ISerializable
	{
		private CHandle<inkWidget> _rootWidget;
		private CHandle<inkIWidgetController> _gameController;
		private CEnum<inkETextureResolution> _rootResolution;

		[Ordinal(0)] 
		[RED("rootWidget")] 
		public CHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(1)] 
		[RED("gameController")] 
		public CHandle<inkIWidgetController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(2)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get => GetProperty(ref _rootResolution);
			set => SetProperty(ref _rootResolution, value);
		}

		public inkWidgetLibraryItemInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
