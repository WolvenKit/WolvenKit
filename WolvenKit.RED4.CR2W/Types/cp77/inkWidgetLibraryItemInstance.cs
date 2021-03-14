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
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameController")] 
		public CHandle<inkIWidgetController> GameController
		{
			get
			{
				if (_gameController == null)
				{
					_gameController = (CHandle<inkIWidgetController>) CR2WTypeManager.Create("handle:inkIWidgetController", "gameController", cr2w, this);
				}
				return _gameController;
			}
			set
			{
				if (_gameController == value)
				{
					return;
				}
				_gameController = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get
			{
				if (_rootResolution == null)
				{
					_rootResolution = (CEnum<inkETextureResolution>) CR2WTypeManager.Create("inkETextureResolution", "rootResolution", cr2w, this);
				}
				return _rootResolution;
			}
			set
			{
				if (_rootResolution == value)
				{
					return;
				}
				_rootResolution = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryItemInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
