using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorResource : CResource
	{
		private CHandle<AIbehaviorTreeNodeDefinition> _root;
		private AITreeArgumentsDefinition _arguments;
		private CHandle<AIbehaviorBehaviorDelegate> _delegate;
		private CArray<CName> _initializationEvents;

		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<AIbehaviorTreeNodeDefinition> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<AIbehaviorTreeNodeDefinition>) CR2WTypeManager.Create("handle:AIbehaviorTreeNodeDefinition", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("arguments")] 
		public AITreeArgumentsDefinition Arguments
		{
			get
			{
				if (_arguments == null)
				{
					_arguments = (AITreeArgumentsDefinition) CR2WTypeManager.Create("AITreeArgumentsDefinition", "arguments", cr2w, this);
				}
				return _arguments;
			}
			set
			{
				if (_arguments == value)
				{
					return;
				}
				_arguments = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delegate")] 
		public CHandle<AIbehaviorBehaviorDelegate> Delegate
		{
			get
			{
				if (_delegate == null)
				{
					_delegate = (CHandle<AIbehaviorBehaviorDelegate>) CR2WTypeManager.Create("handle:AIbehaviorBehaviorDelegate", "delegate", cr2w, this);
				}
				return _delegate;
			}
			set
			{
				if (_delegate == value)
				{
					return;
				}
				_delegate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initializationEvents")] 
		public CArray<CName> InitializationEvents
		{
			get
			{
				if (_initializationEvents == null)
				{
					_initializationEvents = (CArray<CName>) CR2WTypeManager.Create("array:CName", "initializationEvents", cr2w, this);
				}
				return _initializationEvents;
			}
			set
			{
				if (_initializationEvents == value)
				{
					return;
				}
				_initializationEvents = value;
				PropertySet(this);
			}
		}

		public AIbehaviorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
