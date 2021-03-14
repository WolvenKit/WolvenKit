using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstanceDataMappedToReferenceName : CVariable
	{
		private CName _itemHandlingFeatureName;
		private CString _attachmentSlot;

		[Ordinal(0)] 
		[RED("itemHandlingFeatureName")] 
		public CName ItemHandlingFeatureName
		{
			get
			{
				if (_itemHandlingFeatureName == null)
				{
					_itemHandlingFeatureName = (CName) CR2WTypeManager.Create("CName", "itemHandlingFeatureName", cr2w, this);
				}
				return _itemHandlingFeatureName;
			}
			set
			{
				if (_itemHandlingFeatureName == value)
				{
					return;
				}
				_itemHandlingFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attachmentSlot")] 
		public CString AttachmentSlot
		{
			get
			{
				if (_attachmentSlot == null)
				{
					_attachmentSlot = (CString) CR2WTypeManager.Create("String", "attachmentSlot", cr2w, this);
				}
				return _attachmentSlot;
			}
			set
			{
				if (_attachmentSlot == value)
				{
					return;
				}
				_attachmentSlot = value;
				PropertySet(this);
			}
		}

		public InstanceDataMappedToReferenceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
