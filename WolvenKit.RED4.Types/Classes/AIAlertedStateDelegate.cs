using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAlertedStateDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private Vector4 _attackInstigatorPosition;

		[Ordinal(0)] 
		[RED("attackInstigatorPosition")] 
		public Vector4 AttackInstigatorPosition
		{
			get => GetProperty(ref _attackInstigatorPosition);
			set => SetProperty(ref _attackInstigatorPosition, value);
		}
	}
}
