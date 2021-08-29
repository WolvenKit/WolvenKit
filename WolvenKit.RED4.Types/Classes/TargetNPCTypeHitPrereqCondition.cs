using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataNPCType> _type;

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataNPCType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
