using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_Point : toolsIMessageLocation
	{
		private MessageResourcePath _resourcePath;
		private Vector3 _point;

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
		[RED("point")] 
		public Vector3 Point
		{
			get
			{
				if (_point == null)
				{
					_point = (Vector3) CR2WTypeManager.Create("Vector3", "point", cr2w, this);
				}
				return _point;
			}
			set
			{
				if (_point == value)
				{
					return;
				}
				_point = value;
				PropertySet(this);
			}
		}

		public toolsMessageLocation_Point(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
