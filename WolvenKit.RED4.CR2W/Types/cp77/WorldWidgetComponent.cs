using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		private rRef<inkWidgetLibraryResource> _cursorResource;
		private raRef<inkWidgetLibraryResource> _widgetResource;
		private CName _itemNameToSpawn;
		private raRef<CBitmapTexture> _staticTextureResource;
		private worlduiSceneWidgetProperties _sceneWidgetProperties;
		private SUIScreenDefinition _screenDefinition;

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get
			{
				if (_cursorResource == null)
				{
					_cursorResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "cursorResource", cr2w, this);
				}
				return _cursorResource;
			}
			set
			{
				if (_cursorResource == value)
				{
					return;
				}
				_cursorResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("widgetResource")] 
		public raRef<inkWidgetLibraryResource> WidgetResource
		{
			get
			{
				if (_widgetResource == null)
				{
					_widgetResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "widgetResource", cr2w, this);
				}
				return _widgetResource;
			}
			set
			{
				if (_widgetResource == value)
				{
					return;
				}
				_widgetResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("itemNameToSpawn")] 
		public CName ItemNameToSpawn
		{
			get
			{
				if (_itemNameToSpawn == null)
				{
					_itemNameToSpawn = (CName) CR2WTypeManager.Create("CName", "itemNameToSpawn", cr2w, this);
				}
				return _itemNameToSpawn;
			}
			set
			{
				if (_itemNameToSpawn == value)
				{
					return;
				}
				_itemNameToSpawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("staticTextureResource")] 
		public raRef<CBitmapTexture> StaticTextureResource
		{
			get
			{
				if (_staticTextureResource == null)
				{
					_staticTextureResource = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "staticTextureResource", cr2w, this);
				}
				return _staticTextureResource;
			}
			set
			{
				if (_staticTextureResource == value)
				{
					return;
				}
				_staticTextureResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sceneWidgetProperties")] 
		public worlduiSceneWidgetProperties SceneWidgetProperties
		{
			get
			{
				if (_sceneWidgetProperties == null)
				{
					_sceneWidgetProperties = (worlduiSceneWidgetProperties) CR2WTypeManager.Create("worlduiSceneWidgetProperties", "sceneWidgetProperties", cr2w, this);
				}
				return _sceneWidgetProperties;
			}
			set
			{
				if (_sceneWidgetProperties == value)
				{
					return;
				}
				_sceneWidgetProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get
			{
				if (_screenDefinition == null)
				{
					_screenDefinition = (SUIScreenDefinition) CR2WTypeManager.Create("SUIScreenDefinition", "screenDefinition", cr2w, this);
				}
				return _screenDefinition;
			}
			set
			{
				if (_screenDefinition == value)
				{
					return;
				}
				_screenDefinition = value;
				PropertySet(this);
			}
		}

		public WorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
