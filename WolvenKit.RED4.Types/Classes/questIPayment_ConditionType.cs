using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIPayment_ConditionType : questIConditionType
	{
		[Ordinal(0)] 
		[RED("scriptCondition")] 
		public CHandle<IScriptable> ScriptCondition
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}
	}
}
