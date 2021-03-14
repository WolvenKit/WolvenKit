using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_BoundingBox : toolsIMessageLocation
	{
		private MessageResourcePath _resourcePath;
		private Box _box;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get
			{
				if (_resourcePath == null)
				{
					_resourcePath = (MessageResourcePath) CR2WTypeManager.Create("MessageResourcePath", "resourcePath", cr2w, this);
				}
				return _resourcePath;
			}
			set
			{
				if (_resourcePath == value)
				{
					return;
				}
				_resourcePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get
			{
				if (_box == null)
				{
					_box = (Box) CR2WTypeManager.Create("Box", "box", cr2w, this);
				}
				return _box;
			}
			set
			{
				if (_box == value)
				{
					return;
				}
				_box = value;
				PropertySet(this);
			}
		}

		public toolsMessageLocation_BoundingBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
