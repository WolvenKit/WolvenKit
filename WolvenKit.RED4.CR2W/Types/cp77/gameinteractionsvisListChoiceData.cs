using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceData : CVariable
	{
		private CString _localizedName;
		private gameinteractionsChoiceTypeWrapper _type;
		private CName _inputActionName;
		private gameinteractionsChoiceCaption _captionParts;
		private wCHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

		[Ordinal(0)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get
			{
				if (_type == null)
				{
					_type = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get
			{
				if (_inputActionName == null)
				{
					_inputActionName = (CName) CR2WTypeManager.Create("CName", "inputActionName", cr2w, this);
				}
				return _inputActionName;
			}
			set
			{
				if (_inputActionName == value)
				{
					return;
				}
				_inputActionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get
			{
				if (_timeProvider == null)
				{
					_timeProvider = (wCHandle<gameinteractionsvisIVisualizerTimeProvider>) CR2WTypeManager.Create("whandle:gameinteractionsvisIVisualizerTimeProvider", "timeProvider", cr2w, this);
				}
				return _timeProvider;
			}
			set
			{
				if (_timeProvider == value)
				{
					return;
				}
				_timeProvider = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisListChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
