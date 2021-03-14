using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitchControllerPS : MasterControllerPS
	{
		private CEnum<ESwitchAction> _switchAction;
		private TweakDBID _nameForON;
		private TweakDBID _nameForOFF;

		[Ordinal(104)] 
		[RED("switchAction")] 
		public CEnum<ESwitchAction> SwitchAction
		{
			get
			{
				if (_switchAction == null)
				{
					_switchAction = (CEnum<ESwitchAction>) CR2WTypeManager.Create("ESwitchAction", "switchAction", cr2w, this);
				}
				return _switchAction;
			}
			set
			{
				if (_switchAction == value)
				{
					return;
				}
				_switchAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("nameForON")] 
		public TweakDBID NameForON
		{
			get
			{
				if (_nameForON == null)
				{
					_nameForON = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForON", cr2w, this);
				}
				return _nameForON;
			}
			set
			{
				if (_nameForON == value)
				{
					return;
				}
				_nameForON = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("nameForOFF")] 
		public TweakDBID NameForOFF
		{
			get
			{
				if (_nameForOFF == null)
				{
					_nameForOFF = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForOFF", cr2w, this);
				}
				return _nameForOFF;
			}
			set
			{
				if (_nameForOFF == value)
				{
					return;
				}
				_nameForOFF = value;
				PropertySet(this);
			}
		}

		public SimpleSwitchControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
