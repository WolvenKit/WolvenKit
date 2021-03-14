using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxObjectController : inkWidgetLogicController
	{
		private inkWidgetReference _contentWidgetRef;
		private inkWidgetReference _placeholderOffsetWidgetRef;
		private inkShapeWidgetReference _colliderRef;
		private inkMargin _offset;

		[Ordinal(1)] 
		[RED("contentWidgetRef")] 
		public inkWidgetReference ContentWidgetRef
		{
			get
			{
				if (_contentWidgetRef == null)
				{
					_contentWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentWidgetRef", cr2w, this);
				}
				return _contentWidgetRef;
			}
			set
			{
				if (_contentWidgetRef == value)
				{
					return;
				}
				_contentWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("placeholderOffsetWidgetRef")] 
		public inkWidgetReference PlaceholderOffsetWidgetRef
		{
			get
			{
				if (_placeholderOffsetWidgetRef == null)
				{
					_placeholderOffsetWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "placeholderOffsetWidgetRef", cr2w, this);
				}
				return _placeholderOffsetWidgetRef;
			}
			set
			{
				if (_placeholderOffsetWidgetRef == value)
				{
					return;
				}
				_placeholderOffsetWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("colliderRef")] 
		public inkShapeWidgetReference ColliderRef
		{
			get
			{
				if (_colliderRef == null)
				{
					_colliderRef = (inkShapeWidgetReference) CR2WTypeManager.Create("inkShapeWidgetReference", "colliderRef", cr2w, this);
				}
				return _colliderRef;
			}
			set
			{
				if (_colliderRef == value)
				{
					return;
				}
				_colliderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public inkMargin Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (inkMargin) CR2WTypeManager.Create("inkMargin", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		public inkComboBoxObjectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
