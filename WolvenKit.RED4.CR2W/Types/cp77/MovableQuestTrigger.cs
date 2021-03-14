using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableQuestTrigger : gameObject
	{
		private CName _factName;
		private CBool _onlyDetectsPlayer;

		[Ordinal(40)] 
		[RED("factName")] 
		public CName FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CName) CR2WTypeManager.Create("CName", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("onlyDetectsPlayer")] 
		public CBool OnlyDetectsPlayer
		{
			get
			{
				if (_onlyDetectsPlayer == null)
				{
					_onlyDetectsPlayer = (CBool) CR2WTypeManager.Create("Bool", "onlyDetectsPlayer", cr2w, this);
				}
				return _onlyDetectsPlayer;
			}
			set
			{
				if (_onlyDetectsPlayer == value)
				{
					return;
				}
				_onlyDetectsPlayer = value;
				PropertySet(this);
			}
		}

		public MovableQuestTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
