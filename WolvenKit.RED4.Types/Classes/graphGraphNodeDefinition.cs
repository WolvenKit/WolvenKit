using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphNodeDefinition : graphIGraphObjectDefinition
	{
		private CArray<CHandle<graphGraphSocketDefinition>> _sockets;

		[Ordinal(0)] 
		[RED("sockets")] 
		public CArray<CHandle<graphGraphSocketDefinition>> Sockets
		{
			get => GetProperty(ref _sockets);
			set => SetProperty(ref _sockets, value);
		}
	}
}
