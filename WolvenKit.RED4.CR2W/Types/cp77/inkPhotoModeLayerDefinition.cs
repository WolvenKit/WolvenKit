using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		private rRef<inkWidgetLibraryResource> _photoModeResource;
		private rRef<inkWidgetLibraryResource> _stickersResource;
		private rRef<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("photoModeResource")] 
		public rRef<inkWidgetLibraryResource> PhotoModeResource
		{
			get
			{
				if (_photoModeResource == null)
				{
					_photoModeResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "photoModeResource", cr2w, this);
				}
				return _photoModeResource;
			}
			set
			{
				if (_photoModeResource == value)
				{
					return;
				}
				_photoModeResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stickersResource")] 
		public rRef<inkWidgetLibraryResource> StickersResource
		{
			get
			{
				if (_stickersResource == null)
				{
					_stickersResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "stickersResource", cr2w, this);
				}
				return _stickersResource;
			}
			set
			{
				if (_stickersResource == value)
				{
					return;
				}
				_stickersResource = value;
				PropertySet(this);
			}
		}

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

		public inkPhotoModeLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
