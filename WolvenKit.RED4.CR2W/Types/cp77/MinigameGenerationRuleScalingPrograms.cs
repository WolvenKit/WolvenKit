using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		private CHandle<gameIBlackboard> _bbNetwork;
		private CBool _isOfficerBreach;
		private CBool _isRemoteBreach;
		private CBool _isFirstAttempt;

		[Ordinal(7)] 
		[RED("bbNetwork")] 
		public CHandle<gameIBlackboard> BbNetwork
		{
			get
			{
				if (_bbNetwork == null)
				{
					_bbNetwork = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbNetwork", cr2w, this);
				}
				return _bbNetwork;
			}
			set
			{
				if (_bbNetwork == value)
				{
					return;
				}
				_bbNetwork = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get
			{
				if (_isOfficerBreach == null)
				{
					_isOfficerBreach = (CBool) CR2WTypeManager.Create("Bool", "isOfficerBreach", cr2w, this);
				}
				return _isOfficerBreach;
			}
			set
			{
				if (_isOfficerBreach == value)
				{
					return;
				}
				_isOfficerBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get
			{
				if (_isRemoteBreach == null)
				{
					_isRemoteBreach = (CBool) CR2WTypeManager.Create("Bool", "isRemoteBreach", cr2w, this);
				}
				return _isRemoteBreach;
			}
			set
			{
				if (_isRemoteBreach == value)
				{
					return;
				}
				_isRemoteBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isFirstAttempt")] 
		public CBool IsFirstAttempt
		{
			get
			{
				if (_isFirstAttempt == null)
				{
					_isFirstAttempt = (CBool) CR2WTypeManager.Create("Bool", "isFirstAttempt", cr2w, this);
				}
				return _isFirstAttempt;
			}
			set
			{
				if (_isFirstAttempt == value)
				{
					return;
				}
				_isFirstAttempt = value;
				PropertySet(this);
			}
		}

		public MinigameGenerationRuleScalingPrograms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
