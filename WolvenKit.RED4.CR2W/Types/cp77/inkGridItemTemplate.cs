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
			get
			{
				if (_sizeX == null)
				{
					_sizeX = (CUInt32) CR2WTypeManager.Create("Uint32", "sizeX", cr2w, this);
				}
				return _sizeX;
			}
			set
			{
				if (_sizeX == value)
				{
					return;
				}
				_sizeX = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sizeY")] 
		public CUInt32 SizeY
		{
			get
			{
				if (_sizeY == null)
				{
					_sizeY = (CUInt32) CR2WTypeManager.Create("Uint32", "sizeY", cr2w, this);
				}
				return _sizeY;
			}
			set
			{
				if (_sizeY == value)
				{
					return;
				}
				_sizeY = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public inkWidgetLibraryReference Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		public inkGridItemTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
