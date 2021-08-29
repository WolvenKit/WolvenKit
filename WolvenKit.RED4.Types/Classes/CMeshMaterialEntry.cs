using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMeshMaterialEntry : RedBaseClass
	{
		private CName _name;
		private CUInt16 _index;
		private CBool _isLocalInstance;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get => GetProperty(ref _isLocalInstance);
			set => SetProperty(ref _isLocalInstance, value);
		}
	}
}
