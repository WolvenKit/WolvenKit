using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoice : CVariable
	{
		private CString _caption;
		private gameinteractionsChoiceCaption _captionParts;
		private CArray<CVariant> _data;
		private gameinteractionsChoiceMetaData _choiceMetaData;
		private gameinteractionsChoiceLookAtDescriptor _lookAtDescriptor;

		[Ordinal(0)] 
		[RED("caption")] 
		public CString Caption
		{
			get
			{
				if (_caption == null)
				{
					_caption = (CString) CR2WTypeManager.Create("String", "caption", cr2w, this);
				}
				return _caption;
			}
			set
			{
				if (_caption == value)
				{
					return;
				}
				_caption = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get
			{
				if (_captionParts == null)
				{
					_captionParts = (gameinteractionsChoiceCaption) CR2WTypeManager.Create("gameinteractionsChoiceCaption", "captionParts", cr2w, this);
				}
				return _captionParts;
			}
			set
			{
				if (_captionParts == value)
				{
					return;
				}
				_captionParts = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CVariant>) CR2WTypeManager.Create("array:Variant", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("choiceMetaData")] 
		public gameinteractionsChoiceMetaData ChoiceMetaData
		{
			get
			{
				if (_choiceMetaData == null)
				{
					_choiceMetaData = (gameinteractionsChoiceMetaData) CR2WTypeManager.Create("gameinteractionsChoiceMetaData", "choiceMetaData", cr2w, this);
				}
				return _choiceMetaData;
			}
			set
			{
				if (_choiceMetaData == value)
				{
					return;
				}
				_choiceMetaData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lookAtDescriptor")] 
		public gameinteractionsChoiceLookAtDescriptor LookAtDescriptor
		{
			get
			{
				if (_lookAtDescriptor == null)
				{
					_lookAtDescriptor = (gameinteractionsChoiceLookAtDescriptor) CR2WTypeManager.Create("gameinteractionsChoiceLookAtDescriptor", "lookAtDescriptor", cr2w, this);
				}
				return _lookAtDescriptor;
			}
			set
			{
				if (_lookAtDescriptor == value)
				{
					return;
				}
				_lookAtDescriptor = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
