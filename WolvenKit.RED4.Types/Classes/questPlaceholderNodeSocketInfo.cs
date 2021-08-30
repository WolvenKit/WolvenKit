using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlaceholderNodeSocketInfo : RedBaseClass
	{
		private CName _name;
		private CEnum<questSocketType> _type;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<questSocketType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questPlaceholderNodeSocketInfo()
		{
			_type = new() { Value = Enums.questSocketType.Input };
		}
	}
}
