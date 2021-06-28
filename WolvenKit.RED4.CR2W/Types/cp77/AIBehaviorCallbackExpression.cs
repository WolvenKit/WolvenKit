using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBehaviorCallbackExpression : AIbehaviorexpressionScript
	{
		private CName _callbackName;
		private CBool _initialValue;
		private CEnum<ECallbackExpressionActions> _callbackAction;
		private CUInt32 _callbackId;
		private CBool _value;

		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		[Ordinal(1)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get => GetProperty(ref _initialValue);
			set => SetProperty(ref _initialValue, value);
		}

		[Ordinal(2)] 
		[RED("callbackAction")] 
		public CEnum<ECallbackExpressionActions> CallbackAction
		{
			get => GetProperty(ref _callbackAction);
			set => SetProperty(ref _callbackAction, value);
		}

		[Ordinal(3)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetProperty(ref _callbackId);
			set => SetProperty(ref _callbackId, value);
		}

		[Ordinal(4)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public AIBehaviorCallbackExpression(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
