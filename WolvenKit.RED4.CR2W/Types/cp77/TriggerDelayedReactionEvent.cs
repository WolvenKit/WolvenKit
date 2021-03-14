using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		private CBool _initAnim;
		private CEnum<gamedataOutput> _behavior;

		[Ordinal(2)] 
		[RED("initAnim")] 
		public CBool InitAnim
		{
			get
			{
				if (_initAnim == null)
				{
					_initAnim = (CBool) CR2WTypeManager.Create("Bool", "initAnim", cr2w, this);
				}
				return _initAnim;
			}
			set
			{
				if (_initAnim == value)
				{
					return;
				}
				_initAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("behavior")] 
		public CEnum<gamedataOutput> Behavior
		{
			get
			{
				if (_behavior == null)
				{
					_behavior = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "behavior", cr2w, this);
				}
				return _behavior;
			}
			set
			{
				if (_behavior == value)
				{
					return;
				}
				_behavior = value;
				PropertySet(this);
			}
		}

		public TriggerDelayedReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
