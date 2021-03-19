using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCDeathData : animAnimFeature
	{
		private CInt32 _deathType;
		private CInt32 _side;

		[Ordinal(0)] 
		[RED("deathType")] 
		public CInt32 DeathType
		{
			get => GetProperty(ref _deathType);
			set => SetProperty(ref _deathType, value);
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		public AnimFeature_VehicleNPCDeathData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
