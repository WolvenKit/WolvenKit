using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphSocketDefinition : graphIGraphObjectDefinition
	{
		private CName _name;
		private CArray<CHandle<graphGraphConnectionDefinition>> _connections;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("connections")] 
		public CArray<CHandle<graphGraphConnectionDefinition>> Connections
		{
			get => GetProperty(ref _connections);
			set => SetProperty(ref _connections, value);
		}
	}
}
