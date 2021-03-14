using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistractionSetup : CVariable
	{
		private CFloat _stimuliRange;
		private CBool _disableOnActivation;
		private CBool _hasSimpleInteraction;
		private CBool _hasSpiderbotInteraction;
		private CBool _hasQuickHack;
		private CBool _hasComputerInteraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<EngDemoContainer> _skillChecks;
		private CArray<ExplosiveDeviceResourceDefinition> _explosionDefinition;

		[Ordinal(0)] 
		[RED("StimuliRange")] 
		public CFloat StimuliRange
		{
			get
			{
				if (_stimuliRange == null)
				{
					_stimuliRange = (CFloat) CR2WTypeManager.Create("Float", "StimuliRange", cr2w, this);
				}
				return _stimuliRange;
			}
			set
			{
				if (_stimuliRange == value)
				{
					return;
				}
				_stimuliRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disableOnActivation")] 
		public CBool DisableOnActivation
		{
			get
			{
				if (_disableOnActivation == null)
				{
					_disableOnActivation = (CBool) CR2WTypeManager.Create("Bool", "disableOnActivation", cr2w, this);
				}
				return _disableOnActivation;
			}
			set
			{
				if (_disableOnActivation == value)
				{
					return;
				}
				_disableOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get
			{
				if (_hasQuickHack == null)
				{
					_hasQuickHack = (CBool) CR2WTypeManager.Create("Bool", "hasQuickHack", cr2w, this);
				}
				return _hasQuickHack;
			}
			set
			{
				if (_hasQuickHack == value)
				{
					return;
				}
				_hasQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hasComputerInteraction")] 
		public CBool HasComputerInteraction
		{
			get
			{
				if (_hasComputerInteraction == null)
				{
					_hasComputerInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasComputerInteraction", cr2w, this);
				}
				return _hasComputerInteraction;
			}
			set
			{
				if (_hasComputerInteraction == value)
				{
					return;
				}
				_hasComputerInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("skillChecks")] 
		public CHandle<EngDemoContainer> SkillChecks
		{
			get
			{
				if (_skillChecks == null)
				{
					_skillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "skillChecks", cr2w, this);
				}
				return _skillChecks;
			}
			set
			{
				if (_skillChecks == value)
				{
					return;
				}
				_skillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("explosionDefinition")] 
		public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition
		{
			get
			{
				if (_explosionDefinition == null)
				{
					_explosionDefinition = (CArray<ExplosiveDeviceResourceDefinition>) CR2WTypeManager.Create("array:ExplosiveDeviceResourceDefinition", "explosionDefinition", cr2w, this);
				}
				return _explosionDefinition;
			}
			set
			{
				if (_explosionDefinition == value)
				{
					return;
				}
				_explosionDefinition = value;
				PropertySet(this);
			}
		}

		public DistractionSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
