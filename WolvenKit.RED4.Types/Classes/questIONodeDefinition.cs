using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIONodeDefinition : questDisableableNodeDefinition
	{
		private CName _socketName;

		[Ordinal(2)] 
		[RED("socketName")] 
		public CName SocketName
		{
			get => GetProperty(ref _socketName);
			set => SetProperty(ref _socketName, value);
		}
	}
}
