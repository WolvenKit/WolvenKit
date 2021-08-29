using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgAttributeTypeValuePair : ISerializable
	{
		private CEnum<vgEStyleAttributeType> _pe;
		private CVariant _lue;

		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<vgEStyleAttributeType> Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("lue")] 
		public CVariant Lue
		{
			get => GetProperty(ref _lue);
			set => SetProperty(ref _lue, value);
		}
	}
}
