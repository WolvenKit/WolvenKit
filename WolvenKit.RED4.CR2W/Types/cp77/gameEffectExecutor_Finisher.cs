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
			get
			{
				if (_finisherScenarios == null)
				{
					_finisherScenarios = (CArray<CHandle<gameIFinisherScenario>>) CR2WTypeManager.Create("array:handle:gameIFinisherScenario", "finisherScenarios", cr2w, this);
				}
				return _finisherScenarios;
			}
			set
			{
				if (_finisherScenarios == value)
				{
					return;
				}
				_finisherScenarios = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("alwaysUseEntryAnims")] 
		public CBool AlwaysUseEntryAnims
		{
			get
			{
				if (_alwaysUseEntryAnims == null)
				{
					_alwaysUseEntryAnims = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseEntryAnims", cr2w, this);
				}
				return _alwaysUseEntryAnims;
			}
			set
			{
				if (_alwaysUseEntryAnims == value)
				{
					return;
				}
				_alwaysUseEntryAnims = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("allowCameraMovement")] 
		public CBool AllowCameraMovement
		{
			get
			{
				if (_allowCameraMovement == null)
				{
					_allowCameraMovement = (CBool) CR2WTypeManager.Create("Bool", "allowCameraMovement", cr2w, this);
				}
				return _allowCameraMovement;
			}
			set
			{
				if (_allowCameraMovement == value)
				{
					return;
				}
				_allowCameraMovement = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_Finisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
