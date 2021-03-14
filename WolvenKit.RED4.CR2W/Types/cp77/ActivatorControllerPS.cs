using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatorControllerPS : MasterControllerPS
	{
		private CBool _hasSpiderbotInteraction;
		private NodeRef _spiderbotInteractionLocationOverride;
		private CBool _hasSimpleInteraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<GenericContainer> _activatorSkillChecks;
		private CString _alternativeInteractionString;

		[Ordinal(104)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get
			{
				if (_hasSpiderbotInteraction == null)
				{
					_hasSpiderbotInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasSpiderbotInteraction", cr2w, this);
				}
				return _hasSpiderbotInteraction;
			}
			set
			{
				if (_hasSpiderbotInteraction == value)
				{
					return;
				}
				_hasSpiderbotInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get
			{
				if (_spiderbotInteractionLocationOverride == null)
				{
					_spiderbotInteractionLocationOverride = (NodeRef) CR2WTypeManager.Create("NodeRef", "spiderbotInteractionLocationOverride", cr2w, this);
				}
				return _spiderbotInteractionLocationOverride;
			}
			set
			{
				if (_spiderbotInteractionLocationOverride == value)
				{
					return;
				}
				_spiderbotInteractionLocationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get
			{
				if (_hasSimpleInteraction == null)
				{
					_hasSimpleInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasSimpleInteraction", cr2w, this);
				}
				return _hasSimpleInteraction;
			}
			set
			{
				if (_hasSimpleInteraction == value)
				{
					return;
				}
				_hasSimpleInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get
			{
				if (_alternativeInteractionName == null)
				{
					_alternativeInteractionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeInteractionName", cr2w, this);
				}
				return _alternativeInteractionName;
			}
			set
			{
				if (_alternativeInteractionName == value)
				{
					return;
				}
				_alternativeInteractionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get
			{
				if (_alternativeSpiderbotInteractionName == null)
				{
					_alternativeSpiderbotInteractionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeSpiderbotInteractionName", cr2w, this);
				}
				return _alternativeSpiderbotInteractionName;
			}
			set
			{
				if (_alternativeSpiderbotInteractionName == value)
				{
					return;
				}
				_alternativeSpiderbotInteractionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get
			{
				if (_alternativeQuickHackName == null)
				{
					_alternativeQuickHackName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeQuickHackName", cr2w, this);
				}
				return _alternativeQuickHackName;
			}
			set
			{
				if (_alternativeQuickHackName == value)
				{
					return;
				}
				_alternativeQuickHackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("activatorSkillChecks")] 
		public CHandle<GenericContainer> ActivatorSkillChecks
		{
			get
			{
				if (_activatorSkillChecks == null)
				{
					_activatorSkillChecks = (CHandle<GenericContainer>) CR2WTypeManager.Create("handle:GenericContainer", "activatorSkillChecks", cr2w, this);
				}
				return _activatorSkillChecks;
			}
			set
			{
				if (_activatorSkillChecks == value)
				{
					return;
				}
				_activatorSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("alternativeInteractionString")] 
		public CString AlternativeInteractionString
		{
			get
			{
				if (_alternativeInteractionString == null)
				{
					_alternativeInteractionString = (CString) CR2WTypeManager.Create("String", "alternativeInteractionString", cr2w, this);
				}
				return _alternativeInteractionString;
			}
			set
			{
				if (_alternativeInteractionString == value)
				{
					return;
				}
				_alternativeInteractionString = value;
				PropertySet(this);
			}
		}

		public ActivatorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
