using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CInt32 _integer;
		private CFloat _floatValue;
		private CArray<CName> _names;
		private CHandle<AICommand> _command;
		private CBool _newProperty2;
		private CBool _newProperty;
		private CBool _newProperty3;
		private CBool _newProperty4;
		private NodeRef _nodeRef;

		[Ordinal(0)] 
		[RED("integer")] 
		public CInt32 Integer
		{
			get => GetProperty(ref _integer);
			set => SetProperty(ref _integer, value);
		}

		[Ordinal(1)] 
		[RED("floatValue")] 
		public CFloat FloatValue
		{
			get => GetProperty(ref _floatValue);
			set => SetProperty(ref _floatValue, value);
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(3)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(4)] 
		[RED("newProperty2")] 
		public CBool NewProperty2
		{
			get => GetProperty(ref _newProperty2);
			set => SetProperty(ref _newProperty2, value);
		}

		[Ordinal(5)] 
		[RED("newProperty")] 
		public CBool NewProperty
		{
			get => GetProperty(ref _newProperty);
			set => SetProperty(ref _newProperty, value);
		}

		[Ordinal(6)] 
		[RED("newProperty3")] 
		public CBool NewProperty3
		{
			get => GetProperty(ref _newProperty3);
			set => SetProperty(ref _newProperty3, value);
		}

		[Ordinal(7)] 
		[RED("newProperty4")] 
		public CBool NewProperty4
		{
			get => GetProperty(ref _newProperty4);
			set => SetProperty(ref _newProperty4, value);
		}

		[Ordinal(8)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		public TestBehaviorDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
