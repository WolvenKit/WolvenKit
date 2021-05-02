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
			get => GetProperty(ref _coverNodeRef);
			set => SetProperty(ref _coverNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetProperty(ref _alwaysUseStealth);
			set => SetProperty(ref _alwaysUseStealth, value);
		}

		[Ordinal(2)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get => GetProperty(ref _specialAction);
			set => SetProperty(ref _specialAction, value);
		}

		public AIMoveToCoverCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
