using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationChainPlayer : IScriptable
	{
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<AnimationChain> _current;
		private CInt32 _current_stage;
		private CHandle<AnimationChain> _next;
		private wCHandle<inkWidgetLogicController> _owner;

		[Ordinal(0)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("current")] 
		public CHandle<AnimationChain> Current
		{
			get
			{
				if (_current == null)
				{
					_current = (CHandle<AnimationChain>) CR2WTypeManager.Create("handle:AnimationChain", "current", cr2w, this);
				}
				return _current;
			}
			set
			{
				if (_current == value)
				{
					return;
				}
				_current = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("current_stage")] 
		public CInt32 Current_stage
		{
			get
			{
				if (_current_stage == null)
				{
					_current_stage = (CInt32) CR2WTypeManager.Create("Int32", "current_stage", cr2w, this);
				}
				return _current_stage;
			}
			set
			{
				if (_current_stage == value)
				{
					return;
				}
				_current_stage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("next")] 
		public CHandle<AnimationChain> Next
		{
			get
			{
				if (_next == null)
				{
					_next = (CHandle<AnimationChain>) CR2WTypeManager.Create("handle:AnimationChain", "next", cr2w, this);
				}
				return _next;
			}
			set
			{
				if (_next == value)
				{
					return;
				}
				_next = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<inkWidgetLogicController> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<inkWidgetLogicController>) CR2WTypeManager.Create("whandle:inkWidgetLogicController", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public AnimationChainPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
