using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPartDisplay : inkWidgetLogicController
	{
		private inkImageWidgetReference _partIconImage;
		private inkWidgetReference _rarity;
		private CName _texturePartName;
		private InventoryItemAttachments _attachmentData;

		[Ordinal(1)] 
		[RED("PartIconImage")] 
		public inkImageWidgetReference PartIconImage
		{
			get
			{
				if (_partIconImage == null)
				{
					_partIconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "PartIconImage", cr2w, this);
				}
				return _partIconImage;
			}
			set
			{
				if (_partIconImage == value)
				{
					return;
				}
				_partIconImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Rarity")] 
		public inkWidgetReference Rarity
		{
			get
			{
				if (_rarity == null)
				{
					_rarity = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Rarity", cr2w, this);
				}
				return _rarity;
			}
			set
			{
				if (_rarity == value)
				{
					return;
				}
				_rarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("TexturePartName")] 
		public CName TexturePartName
		{
			get
			{
				if (_texturePartName == null)
				{
					_texturePartName = (CName) CR2WTypeManager.Create("CName", "TexturePartName", cr2w, this);
				}
				return _texturePartName;
			}
			set
			{
				if (_texturePartName == value)
				{
					return;
				}
				_texturePartName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attachmentData")] 
		public InventoryItemAttachments AttachmentData
		{
			get
			{
				if (_attachmentData == null)
				{
					_attachmentData = (InventoryItemAttachments) CR2WTypeManager.Create("InventoryItemAttachments", "attachmentData", cr2w, this);
				}
				return _attachmentData;
			}
			set
			{
				if (_attachmentData == value)
				{
					return;
				}
				_attachmentData = value;
				PropertySet(this);
			}
		}

		public InventoryItemPartDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
