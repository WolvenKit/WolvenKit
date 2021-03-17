using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldTransform : CVariable
	{
		private WorldPosition _position;
		private Quaternion _orientation;

		[Ordinal(0)] 
		[RED("Position")] 
		public WorldPosition Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("Orientation")] 
		public Quaternion Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		public WorldTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
