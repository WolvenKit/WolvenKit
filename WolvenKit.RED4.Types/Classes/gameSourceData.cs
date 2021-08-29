using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSourceData : ISerializable
	{
		private CName _name;
		private CBool _savable;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("savable")] 
		public CBool Savable
		{
			get => GetProperty(ref _savable);
			set => SetProperty(ref _savable, value);
		}
	}
}
