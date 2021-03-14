using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		private inkWidgetReference _downloadButton;
		private inkTextWidgetReference _descriptionText;
		private CBool _isVoiceOverInstalled;
		private CInt32 _currentSetIndex;

		[Ordinal(22)] 
		[RED("downloadButton")] 
		public inkWidgetReference DownloadButton
		{
			get
			{
				if (_downloadButton == null)
				{
					_downloadButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "downloadButton", cr2w, this);
				}
				return _downloadButton;
			}
			set
			{
				if (_downloadButton == value)
				{
					return;
				}
				_downloadButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("isVoiceOverInstalled")] 
		public CBool IsVoiceOverInstalled
		{
			get
			{
				if (_isVoiceOverInstalled == null)
				{
					_isVoiceOverInstalled = (CBool) CR2WTypeManager.Create("Bool", "isVoiceOverInstalled", cr2w, this);
				}
				return _isVoiceOverInstalled;
			}
			set
			{
				if (_isVoiceOverInstalled == value)
				{
					return;
				}
				_isVoiceOverInstalled = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("currentSetIndex")] 
		public CInt32 CurrentSetIndex
		{
			get
			{
				if (_currentSetIndex == null)
				{
					_currentSetIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentSetIndex", cr2w, this);
				}
				return _currentSetIndex;
			}
			set
			{
				if (_currentSetIndex == value)
				{
					return;
				}
				_currentSetIndex = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerLanguagesList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
