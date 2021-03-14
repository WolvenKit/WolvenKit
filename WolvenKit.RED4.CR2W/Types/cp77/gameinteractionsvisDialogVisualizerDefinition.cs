using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		private CString _displayNameOverride;
		private CBool _useLookAt;
		private CBool _disableAfterSelectingChoice;
		private CHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;
		private CUInt8 _hubPriority;

		[Ordinal(1)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get
			{
				if (_displayNameOverride == null)
				{
					_displayNameOverride = (CString) CR2WTypeManager.Create("String", "displayNameOverride", cr2w, this);
				}
				return _displayNameOverride;
			}
			set
			{
				if (_displayNameOverride == value)
				{
					return;
				}
				_displayNameOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useLookAt")] 
		public CBool UseLookAt
		{
			get
			{
				if (_useLookAt == null)
				{
					_useLookAt = (CBool) CR2WTypeManager.Create("Bool", "useLookAt", cr2w, this);
				}
				return _useLookAt;
			}
			set
			{
				if (_useLookAt == value)
				{
					return;
				}
				_useLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("disableAfterSelectingChoice")] 
		public CBool DisableAfterSelectingChoice
		{
			get
			{
				if (_disableAfterSelectingChoice == null)
				{
					_disableAfterSelectingChoice = (CBool) CR2WTypeManager.Create("Bool", "disableAfterSelectingChoice", cr2w, this);
				}
				return _disableAfterSelectingChoice;
			}
			set
			{
				if (_disableAfterSelectingChoice == value)
				{
					return;
				}
				_disableAfterSelectingChoice = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get
			{
				if (_timeProvider == null)
				{
					_timeProvider = (CHandle<gameinteractionsvisIVisualizerTimeProvider>) CR2WTypeManager.Create("handle:gameinteractionsvisIVisualizerTimeProvider", "timeProvider", cr2w, this);
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

		[Ordinal(5)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get
			{
				if (_hubPriority == null)
				{
					_hubPriority = (CUInt8) CR2WTypeManager.Create("Uint8", "hubPriority", cr2w, this);
				}
				return _hubPriority;
			}
			set
			{
				if (_hubPriority == value)
				{
					return;
				}
				_hubPriority = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisDialogVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
