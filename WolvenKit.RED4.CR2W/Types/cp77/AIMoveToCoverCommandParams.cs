using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCoverCommandParams : questScriptedAICommandParams
	{
		private NodeRef _coverNodeRef;
		private CBool _alwaysUseStealth;
		private CEnum<ECoverSpecialAction> _specialAction;

		[Ordinal(0)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get
			{
				if (_coverNodeRef == null)
				{
					_coverNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "coverNodeRef", cr2w, this);
				}
				return _coverNodeRef;
			}
			set
			{
				if (_coverNodeRef == value)
				{
					return;
				}
				_coverNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get
			{
				if (_alwaysUseStealth == null)
				{
					_alwaysUseStealth = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseStealth", cr2w, this);
				}
				return _alwaysUseStealth;
			}
			set
			{
				if (_alwaysUseStealth == value)
				{
					return;
				}
				_alwaysUseStealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get
			{
				if (_specialAction == null)
				{
					_specialAction = (CEnum<ECoverSpecialAction>) CR2WTypeManager.Create("ECoverSpecialAction", "specialAction", cr2w, this);
				}
				return _specialAction;
			}
			set
			{
				if (_specialAction == value)
				{
					return;
				}
				_specialAction = value;
				PropertySet(this);
			}
		}

		public AIMoveToCoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
