using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyObjectActionEffector : gameEffector
	{
		private TweakDBID _actionID;
		private CBool _triggered;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get
			{
				if (_triggered == null)
				{
					_triggered = (CBool) CR2WTypeManager.Create("Bool", "triggered", cr2w, this);
				}
				return _triggered;
			}
			set
			{
				if (_triggered == value)
				{
					return;
				}
				_triggered = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		public ApplyObjectActionEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
