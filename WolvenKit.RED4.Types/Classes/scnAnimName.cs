using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAnimName : ISerializable
	{
		private CEnum<scnAnimNameType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnAnimNameType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
