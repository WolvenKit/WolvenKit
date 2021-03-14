using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDeviceVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		private CEnum<gameinteractionsvisInteractionType> _interactionType;
		private CString _displayNameOverride;
		private CBool _useDefaultActionMapping;
		private CBool _createMappin;
		private CBool _isDynamic;
		private CHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

		[Ordinal(1)] 
		[RED("interactionType")] 
		public CEnum<gameinteractionsvisInteractionType> InteractionType
		{
			get
			{
				if (_interactionType == null)
				{
					_interactionType = (CEnum<gameinteractionsvisInteractionType>) CR2WTypeManager.Create("gameinteractionsvisInteractionType", "interactionType", cr2w, this);
				}
				return _interactionType;
			}
			set
			{
				if (_interactionType == value)
				{
					return;
				}
				_interactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("useDefaultActionMapping")] 
		public CBool UseDefaultActionMapping
		{
			get
			{
				if (_useDefaultActionMapping == null)
				{
					_useDefaultActionMapping = (CBool) CR2WTypeManager.Create("Bool", "useDefaultActionMapping", cr2w, this);
				}
				return _useDefaultActionMapping;
			}
			set
			{
				if (_useDefaultActionMapping == value)
				{
					return;
				}
				_useDefaultActionMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("createMappin")] 
		public CBool CreateMappin
		{
			get
			{
				if (_createMappin == null)
				{
					_createMappin = (CBool) CR2WTypeManager.Create("Bool", "createMappin", cr2w, this);
				}
				return _createMappin;
			}
			set
			{
				if (_createMappin == value)
				{
					return;
				}
				_createMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get
			{
				if (_isDynamic == null)
				{
					_isDynamic = (CBool) CR2WTypeManager.Create("Bool", "isDynamic", cr2w, this);
				}
				return _isDynamic;
			}
			set
			{
				if (_isDynamic == value)
				{
					return;
				}
				_isDynamic = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public gameinteractionsvisDeviceVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
