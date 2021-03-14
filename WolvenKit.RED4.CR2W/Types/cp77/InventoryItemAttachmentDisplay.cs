using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachmentDisplay : inkWidgetLogicController
	{
		private inkWidgetReference _qualityRootRef;
		private inkWidgetReference _shapeRef;
		private inkWidgetReference _borderRef;
		private CName _markedStateName;

		[Ordinal(1)] 
		[RED("QualityRootRef")] 
		public inkWidgetReference QualityRootRef
		{
			get
			{
				if (_qualityRootRef == null)
				{
					_qualityRootRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QualityRootRef", cr2w, this);
				}
				return _qualityRootRef;
			}
			set
			{
				if (_qualityRootRef == value)
				{
					return;
				}
				_qualityRootRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ShapeRef")] 
		public inkWidgetReference ShapeRef
		{
			get
			{
				if (_shapeRef == null)
				{
					_shapeRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ShapeRef", cr2w, this);
				}
				return _shapeRef;
			}
			set
			{
				if (_shapeRef == value)
				{
					return;
				}
				_shapeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("BorderRef")] 
		public inkWidgetReference BorderRef
		{
			get
			{
				if (_borderRef == null)
				{
					_borderRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "BorderRef", cr2w, this);
				}
				return _borderRef;
			}
			set
			{
				if (_borderRef == value)
				{
					return;
				}
				_borderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get
			{
				if (_markedStateName == null)
				{
					_markedStateName = (CName) CR2WTypeManager.Create("CName", "MarkedStateName", cr2w, this);
				}
				return _markedStateName;
			}
			set
			{
				if (_markedStateName == value)
				{
					return;
				}
				_markedStateName = value;
				PropertySet(this);
			}
		}

		public InventoryItemAttachmentDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
