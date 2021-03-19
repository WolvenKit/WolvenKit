using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_NavigationImpact : worldEditorDebugColoringSettings
	{
		private CColor _walkable;
		private CColor _ignored;
		private CColor _blocking;
		private CColor _road;
		private CColor _crowd_walkable;
		private CColor _staris_walkable;
		private CColor _drones;
		private CColor _everythign_else;

		[Ordinal(0)] 
		[RED("walkable")] 
		public CColor Walkable
		{
			get => GetProperty(ref _walkable);
			set => SetProperty(ref _walkable, value);
		}

		[Ordinal(1)] 
		[RED("ignored")] 
		public CColor Ignored
		{
			get => GetProperty(ref _ignored);
			set => SetProperty(ref _ignored, value);
		}

		[Ordinal(2)] 
		[RED("blocking")] 
		public CColor Blocking
		{
			get => GetProperty(ref _blocking);
			set => SetProperty(ref _blocking, value);
		}

		[Ordinal(3)] 
		[RED("road")] 
		public CColor Road
		{
			get => GetProperty(ref _road);
			set => SetProperty(ref _road, value);
		}

		[Ordinal(4)] 
		[RED("crowd walkable")] 
		public CColor Crowd_walkable
		{
			get => GetProperty(ref _crowd_walkable);
			set => SetProperty(ref _crowd_walkable, value);
		}

		[Ordinal(5)] 
		[RED("staris walkable")] 
		public CColor Staris_walkable
		{
			get => GetProperty(ref _staris_walkable);
			set => SetProperty(ref _staris_walkable, value);
		}

		[Ordinal(6)] 
		[RED("drones")] 
		public CColor Drones
		{
			get => GetProperty(ref _drones);
			set => SetProperty(ref _drones, value);
		}

		[Ordinal(7)] 
		[RED("everythign else")] 
		public CColor Everythign_else
		{
			get => GetProperty(ref _everythign_else);
			set => SetProperty(ref _everythign_else, value);
		}

		public worldDebugColoring_NavigationImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
