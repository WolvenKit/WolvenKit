using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDescriptionGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _customDescriptionText;
		private CUInt32 _descriptionCallbackID;
		private CBool _isValidDescription;
		private CBool _isValidCustomDescription;

		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customDescriptionText")] 
		public inkTextWidgetReference CustomDescriptionText
		{
			get
			{
				if (_customDescriptionText == null)
				{
					_customDescriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "customDescriptionText", cr2w, this);
				}
				return _customDescriptionText;
			}
			set
			{
				if (_customDescriptionText == value)
				{
					return;
				}
				_customDescriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("descriptionCallbackID")] 
		public CUInt32 DescriptionCallbackID
		{
			get
			{
				if (_descriptionCallbackID == null)
				{
					_descriptionCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "descriptionCallbackID", cr2w, this);
				}
				return _descriptionCallbackID;
			}
			set
			{
				if (_descriptionCallbackID == value)
				{
					return;
				}
				_descriptionCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isValidDescription")] 
		public CBool IsValidDescription
		{
			get
			{
				if (_isValidDescription == null)
				{
					_isValidDescription = (CBool) CR2WTypeManager.Create("Bool", "isValidDescription", cr2w, this);
				}
				return _isValidDescription;
			}
			set
			{
				if (_isValidDescription == value)
				{
					return;
				}
				_isValidDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isValidCustomDescription")] 
		public CBool IsValidCustomDescription
		{
			get
			{
				if (_isValidCustomDescription == null)
				{
					_isValidCustomDescription = (CBool) CR2WTypeManager.Create("Bool", "isValidCustomDescription", cr2w, this);
				}
				return _isValidCustomDescription;
			}
			set
			{
				if (_isValidCustomDescription == value)
				{
					return;
				}
				_isValidCustomDescription = value;
				PropertySet(this);
			}
		}

		public ScannerDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
