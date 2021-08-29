using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MapMenuUserData : IScriptable
	{
		private Vector3 _moveTo;

		[Ordinal(0)] 
		[RED("moveTo")] 
		public Vector3 MoveTo
		{
			get => GetProperty(ref _moveTo);
			set => SetProperty(ref _moveTo, value);
		}
	}
}
