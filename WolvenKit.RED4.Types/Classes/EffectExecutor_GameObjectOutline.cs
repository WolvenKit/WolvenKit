using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_GameObjectOutline : gameEffectExecutor_Scripted
	{
		private CEnum<EOutlineType> _outlineType;

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}
	}
}
