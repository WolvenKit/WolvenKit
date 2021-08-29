using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropdownItemData : IScriptable
	{
		private CVariant _identifier;
		private CName _labelKey;
		private CEnum<DropdownItemDirection> _direction;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("labelKey")] 
		public CName LabelKey
		{
			get => GetProperty(ref _labelKey);
			set => SetProperty(ref _labelKey, value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<DropdownItemDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
