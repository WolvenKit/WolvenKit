using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphSocketDefinition : graphIGraphObjectDefinition
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

		public graphGraphSocketDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
