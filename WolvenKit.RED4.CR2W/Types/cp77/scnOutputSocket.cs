using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocket : CVariable
	{
		private scnOutputSocketStamp _stamp;
		private CArray<scnInputSocketId> _destinations;

		[Ordinal(0)] 
		[RED("stamp")] 
		public scnOutputSocketStamp Stamp
		{
			get => GetProperty(ref _stamp);
			set => SetProperty(ref _stamp, value);
		}

		[Ordinal(1)] 
		[RED("destinations")] 
		public CArray<scnInputSocketId> Destinations
		{
			get => GetProperty(ref _destinations);
			set => SetProperty(ref _destinations, value);
		}

		public scnOutputSocket(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
