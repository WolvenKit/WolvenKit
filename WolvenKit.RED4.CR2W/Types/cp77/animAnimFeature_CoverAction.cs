using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CoverAction : animAnimFeature_AIAction
	{
		private CInt32 _coverStance;
		private CInt32 _coverActionType;
		private CInt32 _coverShootType;
		private CInt32 _movementType;

		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get => GetProperty(ref _coverStance);
			set => SetProperty(ref _coverStance, value);
		}

		[Ordinal(5)] 
		[RED("coverActionType")] 
		public CInt32 CoverActionType
		{
			get => GetProperty(ref _coverActionType);
			set => SetProperty(ref _coverActionType, value);
		}

		[Ordinal(6)] 
		[RED("coverShootType")] 
		public CInt32 CoverShootType
		{
			get => GetProperty(ref _coverShootType);
			set => SetProperty(ref _coverShootType, value);
		}

		[Ordinal(7)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		public animAnimFeature_CoverAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
