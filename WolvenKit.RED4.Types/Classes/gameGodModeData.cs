using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGodModeData : RedBaseClass
	{
		private CEnum<gameGodModeType> _type;
		private CName _source;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameGodModeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}
	}
}
