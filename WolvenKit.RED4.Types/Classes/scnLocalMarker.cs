using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLocalMarker : RedBaseClass
	{
		private Transform _transformLS;
		private CName _name;

		[Ordinal(0)] 
		[RED("transformLS")] 
		public Transform TransformLS
		{
			get => GetProperty(ref _transformLS);
			set => SetProperty(ref _transformLS, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}
	}
}
