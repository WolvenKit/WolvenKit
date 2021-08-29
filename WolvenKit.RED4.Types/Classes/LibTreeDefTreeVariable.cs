using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeVariable : ISerializable
	{
		private CUInt16 _id;
		private CName _readableName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("readableName")] 
		public CName ReadableName
		{
			get => GetProperty(ref _readableName);
			set => SetProperty(ref _readableName, value);
		}
	}
}
