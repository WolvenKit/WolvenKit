using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LifePath_ScriptConditionType : BluelineConditionTypeBase
	{
		private TweakDBID _lifePathId;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("lifePathId")] 
		public TweakDBID LifePathId
		{
			get
			{
				if (_lifePathId == null)
				{
					_lifePathId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lifePathId", cr2w, this);
				}
				return _lifePathId;
			}
			set
			{
				if (_lifePathId == value)
				{
					return;
				}
				_lifePathId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public LifePath_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
