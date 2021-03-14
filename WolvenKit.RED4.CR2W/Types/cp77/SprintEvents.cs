using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SprintEvents : LocomotionGroundEvents
	{
		private CFloat _previousStimTimeStamp;
		private CHandle<gameStatModifierData> _reloadModifier;
		private CBool _isInSecondSprint;
		private CHandle<gameStatModifierData> _sprintModifier;

		[Ordinal(0)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get
			{
				if (_previousStimTimeStamp == null)
				{
					_previousStimTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousStimTimeStamp", cr2w, this);
				}
				return _previousStimTimeStamp;
			}
			set
			{
				if (_previousStimTimeStamp == value)
				{
					return;
				}
				_previousStimTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reloadModifier")] 
		public CHandle<gameStatModifierData> ReloadModifier
		{
			get
			{
				if (_reloadModifier == null)
				{
					_reloadModifier = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "reloadModifier", cr2w, this);
				}
				return _reloadModifier;
			}
			set
			{
				if (_reloadModifier == value)
				{
					return;
				}
				_reloadModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInSecondSprint")] 
		public CBool IsInSecondSprint
		{
			get
			{
				if (_isInSecondSprint == null)
				{
					_isInSecondSprint = (CBool) CR2WTypeManager.Create("Bool", "isInSecondSprint", cr2w, this);
				}
				return _isInSecondSprint;
			}
			set
			{
				if (_isInSecondSprint == value)
				{
					return;
				}
				_isInSecondSprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sprintModifier")] 
		public CHandle<gameStatModifierData> SprintModifier
		{
			get
			{
				if (_sprintModifier == null)
				{
					_sprintModifier = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "sprintModifier", cr2w, this);
				}
				return _sprintModifier;
			}
			set
			{
				if (_sprintModifier == value)
				{
					return;
				}
				_sprintModifier = value;
				PropertySet(this);
			}
		}

		public SprintEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
