using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphImageThumbnail : inkButtonAnimatedController
	{
		private inkWidgetReference _selector;
		private inkWidgetReference _equipped;
		private inkWidgetReference _bg;
		private CInt32 _index;

		[Ordinal(22)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get
			{
				if (_selector == null)
				{
					_selector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("equipped")] 
		public inkWidgetReference Equipped
		{
			get
			{
				if (_equipped == null)
				{
					_equipped = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equipped", cr2w, this);
				}
				return _equipped;
			}
			set
			{
				if (_equipped == value)
				{
					return;
				}
				_equipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get
			{
				if (_bg == null)
				{
					_bg = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bg", cr2w, this);
				}
				return _bg;
			}
			set
			{
				if (_bg == value)
				{
					return;
				}
				_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		public characterCreationBodyMorphImageThumbnail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
