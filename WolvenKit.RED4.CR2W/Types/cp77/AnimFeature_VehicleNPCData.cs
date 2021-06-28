using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCData : animAnimFeature
	{
		private CBool _isDriver;
		private CInt32 _side;

		[Ordinal(0)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get => GetProperty(ref _isDriver);
			set => SetProperty(ref _isDriver, value);
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		public AnimFeature_VehicleNPCData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
