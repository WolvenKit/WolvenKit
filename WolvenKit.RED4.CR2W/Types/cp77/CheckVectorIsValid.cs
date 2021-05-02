using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckVectorIsValid : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;
		private Vector4 _value;

		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetProperty(ref _actionTweakIDMapping);
			set => SetProperty(ref _actionTweakIDMapping, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public CheckVectorIsValid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
