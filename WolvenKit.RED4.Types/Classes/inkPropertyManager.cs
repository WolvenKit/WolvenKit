using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPropertyManager : ISerializable
	{
		private CArray<inkPropertyBinding> _bindings;

		[Ordinal(0)] 
		[RED("bindings")] 
		public CArray<inkPropertyBinding> Bindings
		{
			get => GetProperty(ref _bindings);
			set => SetProperty(ref _bindings, value);
		}
	}
}
