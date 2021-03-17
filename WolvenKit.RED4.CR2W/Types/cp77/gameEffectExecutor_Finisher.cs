using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_Finisher : gameEffectExecutor
	{
		private CArray<CHandle<gameIFinisherScenario>> _finisherScenarios;
		private CBool _alwaysUseEntryAnims;
		private CBool _allowCameraMovement;

		[Ordinal(1)] 
		[RED("finisherScenarios")] 
		public CArray<CHandle<gameIFinisherScenario>> FinisherScenarios
		{
			get => GetProperty(ref _finisherScenarios);
			set => SetProperty(ref _finisherScenarios, value);
		}

		[Ordinal(2)] 
		[RED("alwaysUseEntryAnims")] 
		public CBool AlwaysUseEntryAnims
		{
			get => GetProperty(ref _alwaysUseEntryAnims);
			set => SetProperty(ref _alwaysUseEntryAnims, value);
		}

		[Ordinal(3)] 
		[RED("allowCameraMovement")] 
		public CBool AllowCameraMovement
		{
			get => GetProperty(ref _allowCameraMovement);
			set => SetProperty(ref _allowCameraMovement, value);
		}

		public gameEffectExecutor_Finisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
