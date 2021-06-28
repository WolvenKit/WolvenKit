using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DodgeData : animAnimFeature
	{
		private CInt32 _dodgeType;
		private CInt32 _dodgeDirection;

		[Ordinal(0)] 
		[RED("dodgeType")] 
		public CInt32 DodgeType
		{
			get => GetProperty(ref _dodgeType);
			set => SetProperty(ref _dodgeType, value);
		}

		[Ordinal(1)] 
		[RED("dodgeDirection")] 
		public CInt32 DodgeDirection
		{
			get => GetProperty(ref _dodgeDirection);
			set => SetProperty(ref _dodgeDirection, value);
		}

		public animAnimFeature_DodgeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
